Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

<Serializable>
Public Class ClassJoueur
    Public nom As String
    Public nbMaxCarre As Integer
    Public tempsMin As Integer
    Public nbParties As Integer
    Public cumulTempsJeu As Integer

    Public Sub sauvegarder(dossier As String)
        Dim path As String = dossier & nom & ".txt"
        Dim serialiseur As New BinaryFormatter

        Try
            Dim fichier As FileStream = File.OpenWrite(path)
            serialiseur.Serialize(fichier, Me)

        Catch ex As Exception
            MsgBox("Erreur !")
        End Try
    End Sub

    Public Sub charger(path As String)
        If File.Exists(path) = False Then
            Return
        End If

        Dim fichier As Stream = File.OpenRead(path)
        Dim deserialiseur As New BinaryFormatter
        Dim joueur As joueur = New joueur()
        joueur = CType(deserialiseur.Deserialize(fichier), joueur)
        fichier.Close()
        Me.nom = joueur.nom
        Me.nbMaxCarre = joueur.nbMaxCarre
        Me.tempsMin = joueur.tempsMin
        Me.nbParties = joueur.nbParties
        Me.cumulTempsJeu = joueur.cumulTempsJeu





    End Sub
End Class
