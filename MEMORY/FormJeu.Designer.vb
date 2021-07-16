<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormJeu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LabelJoueur = New System.Windows.Forms.Label()
        Me.LabelTempsRestant = New System.Windows.Forms.Label()
        Me.ButtonAbandon = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Carte0 = New System.Windows.Forms.Label()
        Me.PanelCartes = New System.Windows.Forms.Panel()
        Me.Carte19 = New System.Windows.Forms.Label()
        Me.Carte18 = New System.Windows.Forms.Label()
        Me.Carte17 = New System.Windows.Forms.Label()
        Me.Carte16 = New System.Windows.Forms.Label()
        Me.Carte15 = New System.Windows.Forms.Label()
        Me.Carte14 = New System.Windows.Forms.Label()
        Me.Carte13 = New System.Windows.Forms.Label()
        Me.Carte12 = New System.Windows.Forms.Label()
        Me.Carte11 = New System.Windows.Forms.Label()
        Me.Carte10 = New System.Windows.Forms.Label()
        Me.Carte9 = New System.Windows.Forms.Label()
        Me.Carte8 = New System.Windows.Forms.Label()
        Me.Carte7 = New System.Windows.Forms.Label()
        Me.Carte6 = New System.Windows.Forms.Label()
        Me.Carte5 = New System.Windows.Forms.Label()
        Me.Carte4 = New System.Windows.Forms.Label()
        Me.Carte3 = New System.Windows.Forms.Label()
        Me.Carte2 = New System.Windows.Forms.Label()
        Me.Carte1 = New System.Windows.Forms.Label()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.LabelJoueurNom = New System.Windows.Forms.Label()
        Me.ButtonPause = New System.Windows.Forms.Button()
        Me.PanelCartes.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelJoueur
        '
        Me.LabelJoueur.AutoSize = True
        Me.LabelJoueur.Location = New System.Drawing.Point(40, 20)
        Me.LabelJoueur.Name = "LabelJoueur"
        Me.LabelJoueur.Size = New System.Drawing.Size(66, 20)
        Me.LabelJoueur.TabIndex = 20
        Me.LabelJoueur.Text = "Joueur :"
        '
        'LabelTempsRestant
        '
        Me.LabelTempsRestant.AutoSize = True
        Me.LabelTempsRestant.Location = New System.Drawing.Point(285, 20)
        Me.LabelTempsRestant.Name = "LabelTempsRestant"
        Me.LabelTempsRestant.Size = New System.Drawing.Size(126, 20)
        Me.LabelTempsRestant.TabIndex = 21
        Me.LabelTempsRestant.Text = "Temps Restant :"
        '
        'ButtonAbandon
        '
        Me.ButtonAbandon.BackColor = System.Drawing.Color.LavenderBlush
        Me.ButtonAbandon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAbandon.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush
        Me.ButtonAbandon.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAbandon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.ButtonAbandon.Location = New System.Drawing.Point(631, 12)
        Me.ButtonAbandon.Name = "ButtonAbandon"
        Me.ButtonAbandon.Size = New System.Drawing.Size(133, 36)
        Me.ButtonAbandon.TabIndex = 22
        Me.ButtonAbandon.Text = "Abandon"
        Me.ButtonAbandon.UseVisualStyleBackColor = False
        '
        'Timer
        '
        '
        'Carte0
        '
        Me.Carte0.Location = New System.Drawing.Point(14, 16)
        Me.Carte0.Name = "Carte0"
        Me.Carte0.Size = New System.Drawing.Size(137, 194)
        Me.Carte0.TabIndex = 0
        Me.Carte0.Text = " "
        '
        'PanelCartes
        '
        Me.PanelCartes.Controls.Add(Me.Carte19)
        Me.PanelCartes.Controls.Add(Me.Carte18)
        Me.PanelCartes.Controls.Add(Me.Carte17)
        Me.PanelCartes.Controls.Add(Me.Carte16)
        Me.PanelCartes.Controls.Add(Me.Carte15)
        Me.PanelCartes.Controls.Add(Me.Carte14)
        Me.PanelCartes.Controls.Add(Me.Carte13)
        Me.PanelCartes.Controls.Add(Me.Carte12)
        Me.PanelCartes.Controls.Add(Me.Carte11)
        Me.PanelCartes.Controls.Add(Me.Carte10)
        Me.PanelCartes.Controls.Add(Me.Carte9)
        Me.PanelCartes.Controls.Add(Me.Carte8)
        Me.PanelCartes.Controls.Add(Me.Carte7)
        Me.PanelCartes.Controls.Add(Me.Carte6)
        Me.PanelCartes.Controls.Add(Me.Carte5)
        Me.PanelCartes.Controls.Add(Me.Carte4)
        Me.PanelCartes.Controls.Add(Me.Carte3)
        Me.PanelCartes.Controls.Add(Me.Carte2)
        Me.PanelCartes.Controls.Add(Me.Carte1)
        Me.PanelCartes.Controls.Add(Me.Carte0)
        Me.PanelCartes.Location = New System.Drawing.Point(13, 72)
        Me.PanelCartes.Name = "PanelCartes"
        Me.PanelCartes.Size = New System.Drawing.Size(751, 843)
        Me.PanelCartes.TabIndex = 23
        '
        'Carte19
        '
        Me.Carte19.Location = New System.Drawing.Point(586, 628)
        Me.Carte19.Name = "Carte19"
        Me.Carte19.Size = New System.Drawing.Size(137, 194)
        Me.Carte19.TabIndex = 19
        Me.Carte19.Text = " "
        '
        'Carte18
        '
        Me.Carte18.Location = New System.Drawing.Point(443, 628)
        Me.Carte18.Name = "Carte18"
        Me.Carte18.Size = New System.Drawing.Size(137, 194)
        Me.Carte18.TabIndex = 18
        Me.Carte18.Text = " "
        '
        'Carte17
        '
        Me.Carte17.Location = New System.Drawing.Point(300, 628)
        Me.Carte17.Name = "Carte17"
        Me.Carte17.Size = New System.Drawing.Size(137, 194)
        Me.Carte17.TabIndex = 17
        Me.Carte17.Text = " "
        '
        'Carte16
        '
        Me.Carte16.Location = New System.Drawing.Point(157, 628)
        Me.Carte16.Name = "Carte16"
        Me.Carte16.Size = New System.Drawing.Size(137, 194)
        Me.Carte16.TabIndex = 16
        Me.Carte16.Text = " "
        '
        'Carte15
        '
        Me.Carte15.Location = New System.Drawing.Point(14, 628)
        Me.Carte15.Name = "Carte15"
        Me.Carte15.Size = New System.Drawing.Size(137, 194)
        Me.Carte15.TabIndex = 15
        Me.Carte15.Text = " "
        '
        'Carte14
        '
        Me.Carte14.Location = New System.Drawing.Point(586, 424)
        Me.Carte14.Name = "Carte14"
        Me.Carte14.Size = New System.Drawing.Size(137, 194)
        Me.Carte14.TabIndex = 14
        Me.Carte14.Text = " "
        '
        'Carte13
        '
        Me.Carte13.Location = New System.Drawing.Point(443, 424)
        Me.Carte13.Name = "Carte13"
        Me.Carte13.Size = New System.Drawing.Size(137, 194)
        Me.Carte13.TabIndex = 13
        Me.Carte13.Text = " "
        '
        'Carte12
        '
        Me.Carte12.Location = New System.Drawing.Point(300, 424)
        Me.Carte12.Name = "Carte12"
        Me.Carte12.Size = New System.Drawing.Size(137, 194)
        Me.Carte12.TabIndex = 12
        Me.Carte12.Text = " "
        '
        'Carte11
        '
        Me.Carte11.Location = New System.Drawing.Point(157, 424)
        Me.Carte11.Name = "Carte11"
        Me.Carte11.Size = New System.Drawing.Size(137, 194)
        Me.Carte11.TabIndex = 11
        Me.Carte11.Text = " "
        '
        'Carte10
        '
        Me.Carte10.Location = New System.Drawing.Point(14, 424)
        Me.Carte10.Name = "Carte10"
        Me.Carte10.Size = New System.Drawing.Size(137, 194)
        Me.Carte10.TabIndex = 10
        Me.Carte10.Text = " "
        '
        'Carte9
        '
        Me.Carte9.Location = New System.Drawing.Point(586, 219)
        Me.Carte9.Name = "Carte9"
        Me.Carte9.Size = New System.Drawing.Size(137, 194)
        Me.Carte9.TabIndex = 9
        Me.Carte9.Text = " "
        '
        'Carte8
        '
        Me.Carte8.Location = New System.Drawing.Point(443, 219)
        Me.Carte8.Name = "Carte8"
        Me.Carte8.Size = New System.Drawing.Size(137, 194)
        Me.Carte8.TabIndex = 8
        Me.Carte8.Text = " "
        '
        'Carte7
        '
        Me.Carte7.Location = New System.Drawing.Point(300, 219)
        Me.Carte7.Name = "Carte7"
        Me.Carte7.Size = New System.Drawing.Size(137, 194)
        Me.Carte7.TabIndex = 7
        Me.Carte7.Text = " "
        '
        'Carte6
        '
        Me.Carte6.Location = New System.Drawing.Point(157, 219)
        Me.Carte6.Name = "Carte6"
        Me.Carte6.Size = New System.Drawing.Size(137, 194)
        Me.Carte6.TabIndex = 6
        Me.Carte6.Text = " "
        '
        'Carte5
        '
        Me.Carte5.Location = New System.Drawing.Point(14, 219)
        Me.Carte5.Name = "Carte5"
        Me.Carte5.Size = New System.Drawing.Size(137, 194)
        Me.Carte5.TabIndex = 5
        Me.Carte5.Text = " "
        '
        'Carte4
        '
        Me.Carte4.Location = New System.Drawing.Point(586, 16)
        Me.Carte4.Name = "Carte4"
        Me.Carte4.Size = New System.Drawing.Size(137, 194)
        Me.Carte4.TabIndex = 4
        Me.Carte4.Text = " "
        '
        'Carte3
        '
        Me.Carte3.Location = New System.Drawing.Point(443, 16)
        Me.Carte3.Name = "Carte3"
        Me.Carte3.Size = New System.Drawing.Size(137, 194)
        Me.Carte3.TabIndex = 3
        Me.Carte3.Text = " "
        '
        'Carte2
        '
        Me.Carte2.Location = New System.Drawing.Point(300, 16)
        Me.Carte2.Name = "Carte2"
        Me.Carte2.Size = New System.Drawing.Size(137, 194)
        Me.Carte2.TabIndex = 2
        Me.Carte2.Text = " "
        '
        'Carte1
        '
        Me.Carte1.Location = New System.Drawing.Point(157, 16)
        Me.Carte1.Name = "Carte1"
        Me.Carte1.Size = New System.Drawing.Size(137, 194)
        Me.Carte1.TabIndex = 1
        Me.Carte1.Text = " "
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Location = New System.Drawing.Point(417, 20)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(43, 20)
        Me.LabelTime.TabIndex = 24
        Me.LabelTime.Text = "Time"
        '
        'LabelJoueurNom
        '
        Me.LabelJoueurNom.AutoSize = True
        Me.LabelJoueurNom.Location = New System.Drawing.Point(116, 20)
        Me.LabelJoueurNom.Name = "LabelJoueurNom"
        Me.LabelJoueurNom.Size = New System.Drawing.Size(42, 20)
        Me.LabelJoueurNom.TabIndex = 25
        Me.LabelJoueurNom.Text = "Nom"
        '
        'ButtonPause
        '
        Me.ButtonPause.BackColor = System.Drawing.Color.LavenderBlush
        Me.ButtonPause.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonPause.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush
        Me.ButtonPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPause.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.ButtonPause.Image = Global.MEMORY.My.Resources.Resources.iconPause
        Me.ButtonPause.Location = New System.Drawing.Point(550, 13)
        Me.ButtonPause.Name = "ButtonPause"
        Me.ButtonPause.Size = New System.Drawing.Size(49, 34)
        Me.ButtonPause.TabIndex = 26
        Me.ButtonPause.Text = " "
        Me.ButtonPause.UseVisualStyleBackColor = False
        '
        'FormJeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(785, 918)
        Me.Controls.Add(Me.ButtonPause)
        Me.Controls.Add(Me.LabelJoueurNom)
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.PanelCartes)
        Me.Controls.Add(Me.ButtonAbandon)
        Me.Controls.Add(Me.LabelTempsRestant)
        Me.Controls.Add(Me.LabelJoueur)
        Me.Name = "FormJeu"
        Me.Text = "Jeu"
        Me.PanelCartes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelJoueur As Label
    Friend WithEvents LabelTempsRestant As Label
    Friend WithEvents ButtonAbandon As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents Carte0 As Label
    Friend WithEvents PanelCartes As Panel
    Friend WithEvents Carte4 As Label
    Friend WithEvents Carte3 As Label
    Friend WithEvents Carte2 As Label
    Friend WithEvents Carte1 As Label
    Friend WithEvents Carte5 As Label
    Friend WithEvents Carte19 As Label
    Friend WithEvents Carte18 As Label
    Friend WithEvents Carte17 As Label
    Friend WithEvents Carte16 As Label
    Friend WithEvents Carte15 As Label
    Friend WithEvents Carte14 As Label
    Friend WithEvents Carte13 As Label
    Friend WithEvents Carte12 As Label
    Friend WithEvents Carte11 As Label
    Friend WithEvents Carte10 As Label
    Friend WithEvents Carte9 As Label
    Friend WithEvents Carte8 As Label
    Friend WithEvents Carte7 As Label
    Friend WithEvents Carte6 As Label
    Friend WithEvents LabelTime As Label
    Friend WithEvents LabelJoueurNom As Label
    Friend WithEvents ButtonPause As Button
End Class
