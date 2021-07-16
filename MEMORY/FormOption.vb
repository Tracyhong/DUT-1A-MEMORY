Public Class FormOption
    Private Sub FormOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxFilePath.Enabled = False
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        Dim save As New SaveFileDialog
        save.Filter = "Fichier texte|*.txt"
        If save.ShowDialog = 1 Then
            TextBoxFilePath.Text = save.FileName
        End If
    End Sub

    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        Me.Close()
        FormMenu.Show()
    End Sub

    Private Sub ButtonEnregistrer_Click(sender As Object, e As EventArgs) Handles ButtonEnregistrer.Click
        'pause
        If RadioButtonPause.Checked Then
            btnPause = True
        Else btnPause = False
        End If
        'niveau
        If RadioButtonFacile.Checked = True Then
            niveau = "facile"
        End If
        If RadioButtonNormal.Checked = True Then
            niveau = "normal"
        End If
        If RadioButtonDur.Checked = True Then
            niveau = "dur"
        End If
        'temps
        If Not TextBoxTemps.Text = "" Then
            chrono = TextBoxTemps.Text
        End If

        'save
        If Not TextBoxFilePath.Text = "" Then
            path = TextBoxFilePath.Text
        End If
        Me.Close()
        FormMenu.Show()

    End Sub

    Private Sub TextBoxTemps_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTemps.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub
End Class