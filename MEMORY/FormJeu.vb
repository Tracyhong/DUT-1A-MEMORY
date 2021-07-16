Public Class FormJeu

    Dim tempsRestant As Integer = chrono
    Dim carresValide As Integer = 0
    Dim carresTempsMin As Integer = 0
    Dim pause As Boolean = False
    Private Sub FormJeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Interval = 1000
        LabelTime.Text = tempsRestant
        ButtonPause.Visible = False
        If btnPause Then
            ButtonPause.Visible = True
        End If
    End Sub
    Private Sub ButtonAbandon_Click(sender As Object, e As EventArgs) Handles ButtonAbandon.Click
        MsgBox("Voulez-vous vraiment abandonner ?", vbYesNo + vbQuestion + vbDefaultButton2, "Quitter ?")

        If vbYes Then
            FormMenu.Show()
            Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If tempsRestant < 20 Then
            LabelTime.ForeColor = Color.Red
        End If
        If tempsRestant = 0 Then
            Timer.Stop()
            MsgBox("Trop tard ! Vous avez perdu :(" + vbCrLf + "Vous avez trouvé seulement " + carresValide.ToString + " carrés !", vbCritical + vbOKOnly, "Perdu")
            'enregistrer score
            enregistrerJoueur(Me.LabelJoueurNom.Text, carresValide, carresTempsMin, 60)
            Me.Close()
            FormMenu.Show()
        End If
        tempsRestant -= 1
        LabelTime.Text = tempsRestant
    End Sub

    Private Sub Cartes_Click(sender As Object, e As EventArgs) Handles Carte0.Click, Carte1.Click, Carte2.Click, Carte3.Click, Carte4.Click, Carte5.Click, Carte6.Click, Carte7.Click, Carte8.Click, Carte9.Click, Carte10.Click, Carte11.Click, Carte12.Click, Carte13.Click, Carte14.Click, Carte15.Click, Carte16.Click, Carte17.Click, Carte18.Click, Carte19.Click
        If Not startTimer Then
            Timer.Start()
            startTimer = True
        End If
        'verifier que le clic n'est pas déjà fait sur une des cartes

        'si c'est en pause alors exit sub
        If pause = True Then
            Exit Sub
        End If

        If cptClic > 1 AndAlso sender.image Is Cartes(sender.tabindex) Then
            Exit Sub
        End If
        sender.image = Cartes(sender.tabindex)

        tabClic(cptClic) = sender
        cptClic += 1

        If cptClic > 1 Then
            If Not comparerImage(cptClic - 1) Then
                Refresh()
                System.Threading.Thread.Sleep(800)
                'toutes les cartes retournées doivent se retourner sauf celles trouvées (not enabled)
                For i As Integer = 0 To cptClic - 1
                    tabClic(i).Image = BackCard
                Next
                cptClic = 0
            End If
        End If

        If cptClic = 4 Then
            For i As Integer = 0 To cptClic - 1
                tabClic(i).Enabled = False
            Next
            cptClic = 0
            'pour enregistrement
            carresValide += 1
            carresTempsMin = 60 - tempsRestant
        End If

        If verifGagner() Then
            Timer.Stop()
            Dim tempsFin As Integer = 60 - tempsRestant
            MsgBox("Bravo " + LabelJoueurNom.Text + " ! Vous avez gagné ! :D" + vbCrLf + "Vous avez trouvé en " + tempsFin.ToString + " secondes !", vbOKOnly + vbInformation + vbDefaultButton1, "Félicitation")
            'enregistrer score

            enregistrerJoueur(Me.LabelJoueurNom.Text, carresValide, carresTempsMin, tempsFin)

            'quitter
            Me.Close()
            FormMenu.Show()
        End If
        'echangerCarte(sender)

    End Sub

    'OPTION PAUSE
    Private Sub ButtonPause_Click(sender As Object, e As EventArgs) Handles ButtonPause.Click
        If startTimer = False Then
            Exit Sub
        End If
        If sender.image Is IconPause Then
            sender.image = IconPlay
            'stop timer
            Timer.Stop()
            pause = True

        Else sender.image = IconPause
            'relancer le timer
            Timer.Start()
            'laisser jouer
            pause = False
        End If
    End Sub
End Class