Imports System.Linq

''' <summary>
''' Génère un jeu de données d'entraînement synthétique, utilisé tant qu'il n'y a pas
''' assez d'historique réel dans la base. Les relations entre variables sont construites
''' pour rester pédagogiquement réalistes (une moyenne des notes précédentes élevée et
''' peu d'absences prédisent une meilleure note finale, avec du bruit aléatoire pour
''' éviter un signal trop parfait).
'''
''' IMPORTANT : dès que l'application aura accumulé suffisamment de vraies notes
''' (voir NoteRepository), remplacez l'appel à GenererJeuSynthetique() par une lecture
''' des données réelles (méthode ExtraireDonneesReelles ci-dessous, à compléter).
''' </summary>
Public Module GenerateurDonnees

    Public Function GenererJeuSynthetique(Optional nombreExemples As Integer = 1500,
                                           Optional graine As Integer = 42) As List(Of DonneesEleveML)
        Dim alea As New Random(graine)
        Dim jeu As New List(Of DonneesEleveML)

        For i As Integer = 1 To nombreExemples
            Dim moyennePrecedente As Single = CSng(alea.NextDouble() * 20)
            Dim absences As Single = CSng(alea.Next(0, 12))

            ' Les notes de la période sont corrélées à la moyenne précédente, avec un bruit individuel
            Dim n1 As Single = Contraindre(moyennePrecedente + Bruit(alea, 3))
            Dim n2 As Single = Contraindre(moyennePrecedente + Bruit(alea, 3))
            Dim n3 As Single = Contraindre(moyennePrecedente + Bruit(alea, 3))

            ' La note finale dépend des notes de la période, pénalisée par les absences, + bruit
            Dim moyennePeriode As Single = (n1 + n2 + n3) / 3.0F
            Dim penaliteAbsences As Single = absences * 0.35F
            Dim noteFinale As Single = Contraindre(moyennePeriode - penaliteAbsences + Bruit(alea, 1.5F))

            jeu.Add(New DonneesEleveML With {
                .Note1 = n1,
                .Note2 = n2,
                .Note3 = n3,
                .Absences = absences,
                .MoyennePrecedente = moyennePrecedente,
                .NoteFinale = noteFinale,
                .EnDifficulte = noteFinale < 10.0F
            })
        Next

        Return jeu
    End Function

    Private Function Bruit(alea As Random, amplitude As Single) As Single
        Return CSng((alea.NextDouble() - 0.5) * 2 * amplitude)
    End Function

    Private Function Contraindre(valeur As Single) As Single
        Return Math.Max(0.0F, Math.Min(20.0F, valeur))
    End Function

    ''' <summary>
    ''' Point d'extension : convertit les données réelles de la base (EleveRepository /
    ''' NoteRepository) au même format que GenererJeuSynthetique, pour ré-entraîner
    ''' les modèles sur des données réelles une fois qu'il y en a assez (ex. > 200 élèves).
    ''' </summary>
    Public Function ExtraireDonneesReelles(elevesRepo As EleveRepository, notesRepo As NoteRepository) As List(Of DonneesEleveML)
        Dim jeu As New List(Of DonneesEleveML)
        For Each eleve In elevesRepo.ListerTous()
            Dim notes = notesRepo.ListerParEleve(eleve.Id)
            If notes.Count < 4 Then Continue For ' pas assez d'historique pour cet élève

            Dim absences As Integer = notesRepo.CompterAbsences(eleve.Id)
            Dim notesPrecedentes = notes.Take(notes.Count - 1).ToList()
            Dim noteFinale As Single = CSng(notes.Last())
            Dim moyennePrecedente As Single = CSng(notesPrecedentes.Average())

            jeu.Add(New DonneesEleveML With {
                .Note1 = CSng(notesPrecedentes(0)),
                .Note2 = CSng(notesPrecedentes(Math.Min(1, notesPrecedentes.Count - 1))),
                .Note3 = CSng(notesPrecedentes(Math.Min(2, notesPrecedentes.Count - 1))),
                .Absences = absences,
                .MoyennePrecedente = moyennePrecedente,
                .NoteFinale = noteFinale,
                .EnDifficulte = noteFinale < 10.0F
            })
        Next
        Return jeu
    End Function

End Module
