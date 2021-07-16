Public Class FormScore
    Dim liste As New List(Of joueur)
    Private Sub FormScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        liste.Add(Joueurs.Item(0))
        For i As Integer = 1 To Joueurs.Count - 1
            For Each j As joueur In liste
                If Joueurs.Item(i).nbMaxCarre > j.nbMaxCarre Then
                    liste.Insert(liste.IndexOf(j), Joueurs.Item(i))
                    Exit For
                ElseIf Joueurs.Item(i).nbMaxCarre = j.nbMaxCarre And Joueurs.Item(i).tempsMin < j.tempsMin Then
                    liste.Insert(liste.IndexOf(j), Joueurs.Item(i))
                    Exit For
                End If
            Next
            If Not liste.Contains(Joueurs.Item(i)) Then
                liste.Add(Joueurs.Item(i))
            End If
        Next


        For Each j As joueur In liste
            ListBoxNom.Items.Add(j.nom)
            ListBoxScore.Items.Add("Nb Max Carre : " & j.nbMaxCarre & " | Temps Min : " & j.tempsMin & " | Nb Parties : " & j.nbParties & " | Temps cumulé : " & j.cumulTempsJeu)
            ComboBoxNomJoueur.Items.Add(j.nom)
        Next

    End Sub




    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNom.SelectedIndexChanged, ListBoxScore.SelectedIndexChanged 'ajouter les autres listbox
        'faire la synchro avec les autres listbox
        ListBoxNom.SelectedIndex = sender.selectedindex
        ListBoxNom.TopIndex = sender.selectedindex
        ListBoxScore.SelectedIndex = sender.selectedindex
        ListBoxScore.TopIndex = sender.selectedindex
        ComboBoxNomJoueur.SelectedIndex = sender.selectedindex
    End Sub


    Dim info As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonInfos.Click
        If Not ComboBoxNomJoueur.Text = "" Then
            MsgBox(info, vbInformation + vbOKOnly, "Informations de " + ComboBoxNomJoueur.Text)
        End If
    End Sub

    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNomJoueur.SelectedIndexChanged
        For Each j As joueur In Joueurs
            If j.nom = ComboBoxNomJoueur.Text Then
                info = "Nom : " + ComboBoxNomJoueur.Text + vbCrLf + "Nombre de carré trouvé : " + j.nbMaxCarre.ToString + vbCrLf + "Temps min pour trouver : " + j.tempsMin.ToString + vbCrLf + "Nombre de parties : " + j.nbParties.ToString + vbCrLf + "Temps cumulé : " + j.cumulTempsJeu.ToString + " secondes"
            End If
        Next
    End Sub

    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        Me.Close()
        FormMenu.Show()
    End Sub

    Private Sub ButtonTrier_Click_1(sender As Object, e As EventArgs) Handles ButtonTrier.Click
        If ButtonTrier.Text = "<" Then
            ButtonTrier.Text = ">"
            'Dim dernier As Integer = 'ListBoxNom.Items.Count - 1
            ListBoxNom.Items.Clear()
            ListBoxScore.Items.Clear()
            ComboBoxNomJoueur.Items.Clear()

            For i As Integer = liste.Count - 1 To 0 Step -1
                ListBoxNom.Items.Add(liste.Item(i).nom)
                ListBoxScore.Items.Add("Nb Max Carre : " & liste.Item(i).nbMaxCarre & " | Temps Min : " & liste.Item(i).tempsMin & " | Nb Parties : " & liste.Item(i).nbParties & " | Temps cumulé : " & liste.Item(i).cumulTempsJeu)
                ComboBoxNomJoueur.Items.Add(liste.Item(i).nom)

            Next
        Else
            ButtonTrier.Text = "<"
            ListBoxNom.Items.Clear()
            ListBoxScore.Items.Clear()
            ComboBoxNomJoueur.Items.Clear()
            For i As Integer = 0 To liste.Count - 1
                ListBoxNom.Items.Add(liste.Item(i).nom)
                ListBoxScore.Items.Add("Nb Max Carre : " & liste.Item(i).nbMaxCarre & " | Temps Min : " & liste.Item(i).tempsMin & " | Nb Parties : " & liste.Item(i).nbParties & " | Temps cumulé : " & liste.Item(i).cumulTempsJeu)
                ComboBoxNomJoueur.Items.Add(liste.Item(i).nom)
            Next
        End If
    End Sub



End Class