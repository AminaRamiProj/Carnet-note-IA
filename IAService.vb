Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports System.Text.Json
Imports System.Threading.Tasks
Imports System.Linq

''' <summary>
''' Service central qui centralise tous les appels à l'IA (Claude - Anthropic).
''' Toute la logique "IA" de l'application passe par cette classe : ainsi, si un jour
''' vous changez de fournisseur (OpenAI, Mistral, etc.), un seul fichier à modifier.
''' </summary>
Public Class IAService

    ' ----------------------------------------------------------------------
    ' CONFIGURATION
    ' ----------------------------------------------------------------------
    ' La clé API n'est JAMAIS écrite en dur dans le code (mauvaise pratique et risque
    ' de sécurité si le code est partagé). Elle est lue depuis une variable d'environnement
    ' ou un fichier local "api_key.txt" (voir IAConfig.vb).
    Private ReadOnly ApiKey As String
    Private Const ApiUrl As String = "https://api.anthropic.com/v1/messages"
    Private Const Modele As String = "claude-sonnet-4-6"
    Private Shared ReadOnly Client As New HttpClient()

    Public Sub New()
        ApiKey = IAConfig.ObtenirCleApi()
    End Sub

    ''' <summary>
    ''' Vérifie si le module IA est configuré (clé API présente).
    ''' A appeler avant d'afficher les boutons IA pour éviter les erreurs.
    ''' </summary>
    Public Function EstConfigure() As Boolean
        Return Not String.IsNullOrWhiteSpace(ApiKey)
    End Function

    ''' <summary>
    ''' Envoie un prompt système + un message utilisateur à Claude et renvoie le texte de la réponse.
    ''' Fonction générique réutilisée par toutes les fonctionnalités IA ci-dessous.
    ''' </summary>
    Private Async Function AppelerClaudeAsync(systemPrompt As String, messageUtilisateur As String, Optional maxTokens As Integer = 600) As Task(Of String)
        If Not EstConfigure() Then
            Return "⚠ Le module IA n'est pas configuré. Ajoutez votre clé API (voir IAConfig.vb)."
        End If

        Dim corpsRequete As New With {
            .model = Modele,
            .max_tokens = maxTokens,
            .system = systemPrompt,
            .messages = New Object() {
                New With {.role = "user", .content = messageUtilisateur}
            }
        }

        Dim json As String = JsonSerializer.Serialize(corpsRequete)

        Using requete As New HttpRequestMessage(HttpMethod.Post, ApiUrl)
            requete.Headers.Add("x-api-key", ApiKey)
            requete.Headers.Add("anthropic-version", "2023-06-01")
            requete.Content = New StringContent(json, Encoding.UTF8, "application/json")

            Try
                Dim reponse As HttpResponseMessage = Await Client.SendAsync(requete)
                Dim contenuBrut As String = Await reponse.Content.ReadAsStringAsync()

                If Not reponse.IsSuccessStatusCode Then
                    Return $"⚠ Erreur API ({CInt(reponse.StatusCode)}) : {contenuBrut}"
                End If

                Using doc As JsonDocument = JsonDocument.Parse(contenuBrut)
                    Dim texte As New StringBuilder()
                    For Each bloc In doc.RootElement.GetProperty("content").EnumerateArray()
                        If bloc.GetProperty("type").GetString() = "text" Then
                            texte.Append(bloc.GetProperty("text").GetString())
                        End If
                    Next
                    Return texte.ToString().Trim()
                End Using

            Catch ex As Exception
                Return $"⚠ Erreur de connexion à l'IA : {ex.Message}"
            End Try
        End Using
    End Function

    ' ----------------------------------------------------------------------
    ' FONCTIONNALITÉ 1 — APPRÉCIATION AUTOMATIQUE DE BULLETIN
    ' ----------------------------------------------------------------------
    ''' <summary>
    ''' Génère une appréciation professionnelle et personnalisée pour un élève,
    ''' à partir de son nom, de ses notes et de la matière concernée.
    ''' </summary>
    Public Async Function GenererAppreciationAsync(nomEleve As String, notes As List(Of Double), matiere As String,
                                                     Optional observationsEnseignant As String = "") As Task(Of String)
        Dim moyenne As Double = If(notes.Count > 0, notes.Average(), 0)
        Dim notesTexte As String = String.Join(", ", notes)

        Dim systemPrompt As String =
            "Tu es un enseignant expérimenté qui rédige des appréciations de bulletin scolaire en français. " &
            "Style professionnel, bienveillant, constructif, concis (2 à 3 phrases maximum). " &
            "Mentionne un point fort et, si pertinent, un axe d'amélioration concret. " &
            "Ne répète jamais simplement la moyenne chiffrée, interprète-la."

        Dim message As String =
            $"Élève : {nomEleve}" & vbCrLf &
            $"Matière : {matiere}" & vbCrLf &
            $"Notes obtenues : {notesTexte}" & vbCrLf &
            $"Moyenne : {Math.Round(moyenne, 2)}/20" & vbCrLf &
            If(String.IsNullOrWhiteSpace(observationsEnseignant), "",
               $"Remarques de l'enseignant : {observationsEnseignant}" & vbCrLf) &
            "Rédige l'appréciation de bulletin pour cet élève."

        Return Await AppelerClaudeAsync(systemPrompt, message, 300)
    End Function

    ' ----------------------------------------------------------------------
    ' FONCTIONNALITÉ 2 — ANALYSE DE CLASSE & DÉTECTION D'ÉLÈVES EN DIFFICULTÉ
    ' ----------------------------------------------------------------------
    ''' <summary>
    ''' Analyse l'ensemble de la classe : identifie les élèves en difficulté,
    ''' les tendances générales, et propose des recommandations pédagogiques.
    ''' </summary>
    Public Async Function AnalyserClasseAsync(eleves As List(Of ElevePourAnalyse)) As Task(Of String)
        Dim sb As New StringBuilder()
        For Each e In eleves
            Dim moyenne As Double = If(e.Notes.Count > 0, e.Notes.Average(), 0)
            sb.AppendLine($"- {e.Nom} : notes = [{String.Join(", ", e.Notes)}], moyenne = {Math.Round(moyenne, 2)}/20")
        Next

        Dim systemPrompt As String =
            "Tu es un conseiller pédagogique qui analyse les résultats d'une classe entière. " &
            "Réponds en français, de façon structurée avec des puces courtes : " & vbCrLf &
            "1) Tendance générale de la classe (moyenne, dispersion) " & vbCrLf &
            "2) Élèves en difficulté nécessitant une attention particulière (moyenne faible OU forte baisse) " & vbCrLf &
            "3) Élèves en réussite à valoriser " & vbCrLf &
            "4) Deux recommandations pédagogiques concrètes pour l'enseignant. " &
            "Reste concis et actionnable."

        Dim message As String = "Voici les résultats de la classe :" & vbCrLf & sb.ToString()

        Return Await AppelerClaudeAsync(systemPrompt, message, 800)
    End Function

    ' ----------------------------------------------------------------------
    ' FONCTIONNALITÉ 3 — ASSISTANT CONVERSATIONNEL (CHAT SUR LES DONNÉES)
    ' ----------------------------------------------------------------------
    ''' <summary>
    ''' Permet à l'enseignant de poser une question en langage naturel sur les données
    ''' de la classe (ex : "Quels élèves ont une moyenne en dessous de 10 ?").
    ''' Le contexte (liste des élèves et notes) est injecté dans le prompt.
    ''' </summary>
    Public Async Function PoserQuestionAsync(question As String, eleves As List(Of ElevePourAnalyse),
                                              Optional historique As List(Of (Role As String, Texte As String)) = Nothing) As Task(Of String)
        Dim contexte As New StringBuilder()
        For Each e In eleves
            Dim moyenne As Double = If(e.Notes.Count > 0, e.Notes.Average(), 0)
            contexte.AppendLine($"- {e.Nom} : notes = [{String.Join(", ", e.Notes)}], moyenne = {Math.Round(moyenne, 2)}/20")
        Next

        Dim systemPrompt As String =
            "Tu es l'assistant intégré à un logiciel de carnet de notes scolaire (VB.NET). " &
            "Tu réponds en français, de façon brève et précise, aux questions de l'enseignant " &
            "sur les données de sa classe fournies ci-dessous. Si l'information demandée n'est pas " &
            "dans les données, dis-le clairement plutôt que d'inventer."

        Dim message As String =
            "Données de la classe :" & vbCrLf & contexte.ToString() & vbCrLf &
            "Question de l'enseignant : " & question

        Return Await AppelerClaudeAsync(systemPrompt, message, 500)
    End Function

End Class

''' <summary>
''' Petite structure utilitaire utilisée pour transmettre les données d'un élève
''' au service IA (indépendante de votre structure Str_eleve existante, pour rester
''' simple à brancher n'importe où dans l'appli).
''' </summary>
Public Class ElevePourAnalyse
    Public Property Nom As String
    Public Property Notes As New List(Of Double)
End Class
