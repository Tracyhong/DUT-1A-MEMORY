Imports System.ComponentModel

Public Class FormMenu
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each j In Joueurs
            ComboBoxNom.Items.Add(j.nom)
        Next
        ButtonJouer.Enabled = False
    End Sub
    Private Sub ButtonScores_Click(sender As Object, e As EventArgs) Handles ButtonScores.Click
        Me.Hide()
        FormScore.Show()

    End Sub
    Private Sub ButtonOption_Click(sender As Object, e As EventArgs) Handles ButtonOption.Click
        Me.Hide()
        FormOption.Show()
    End Sub
    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Dim quitter = MsgBox("Voulez vous vraiment quitter le jeu", vbYesNo + vbQuestion + vbDefaultButton2, "Arrêt")
        If quitter = vbYes Then
            'enregistrer dans les fichiers 
            For Each joueur In Joueurs
                save(path, joueur)
            Next
            Application.Exit()
        End If
    End Sub
    Private Sub ComboBoxNom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNom.TextChanged
        If ComboBoxNom.Text.Length > 2 Then    'prendre en compte les espaces.
            ButtonJouer.Enabled = True
        Else
            ButtonJouer.Enabled = False
        End If
        'ButtonJouer.Enabled=Len(ComboBoxNom.Text) > 2
    End Sub

    Private Sub ButtonJouer_Click(sender As Object, e As EventArgs) Handles ButtonJouer.Click
        'verifier si le nom n'existe pas déjà sinon ajouter 
        Dim nom As String = ComboBoxNom.Text
        If ComboBoxNom.FindString(nom) < 0 Then
            ComboBoxNom.Items.Add(nom)
        End If

        FormJeu.LabelJoueurNom.Text = nom
        Me.Hide()
        FormJeu.Show()
        init()

    End Sub

    Private Sub FormMenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MsgBox("Voulez vous vraiment quitter le jeu", vbYesNo + vbQuestion + vbDefaultButton2, "Arrêt") = vbNo Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ComboBoxNom_LostFocus(sender As Object, e As EventArgs) Handles ComboBoxNom.LostFocus
        ComboBoxNom.Text = StrConv(ComboBoxNom.Text, VbStrConv.ProperCase)
        ComboBoxNom.Text.Trim()

    End Sub

    Private Sub ComboBoxNom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxNom.KeyPress
        If e.KeyChar = vbBack Then
            Exit Sub
        End If

        If InStr(ComboBoxNom.Text, "  ") Then
            e.Handled = True
        End If

    End Sub


End Class