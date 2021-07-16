<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormScore
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
        Me.ComboBoxNomJoueur = New System.Windows.Forms.ComboBox()
        Me.ButtonInfos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxNom = New System.Windows.Forms.ListBox()
        Me.TitreScore = New System.Windows.Forms.Label()
        Me.ListBoxScore = New System.Windows.Forms.ListBox()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.ButtonTrier = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBoxNomJoueur
        '
        Me.ComboBoxNomJoueur.BackColor = System.Drawing.Color.LavenderBlush
        Me.ComboBoxNomJoueur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxNomJoueur.FormattingEnabled = True
        Me.ComboBoxNomJoueur.Location = New System.Drawing.Point(296, 383)
        Me.ComboBoxNomJoueur.Name = "ComboBoxNomJoueur"
        Me.ComboBoxNomJoueur.Size = New System.Drawing.Size(218, 28)
        Me.ComboBoxNomJoueur.TabIndex = 0
        '
        'ButtonInfos
        '
        Me.ButtonInfos.BackColor = System.Drawing.Color.LavenderBlush
        Me.ButtonInfos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonInfos.Location = New System.Drawing.Point(624, 367)
        Me.ButtonInfos.Name = "ButtonInfos"
        Me.ButtonInfos.Size = New System.Drawing.Size(99, 59)
        Me.ButtonInfos.TabIndex = 1
        Me.ButtonInfos.Text = "Infos"
        Me.ButtonInfos.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(72, 386)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Chercher un joueur :"
        '
        'ListBoxNom
        '
        Me.ListBoxNom.BackColor = System.Drawing.SystemColors.Window
        Me.ListBoxNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.ListBoxNom.FormattingEnabled = True
        Me.ListBoxNom.ItemHeight = 20
        Me.ListBoxNom.Location = New System.Drawing.Point(98, 76)
        Me.ListBoxNom.Name = "ListBoxNom"
        Me.ListBoxNom.Size = New System.Drawing.Size(103, 244)
        Me.ListBoxNom.TabIndex = 3
        '
        'TitreScore
        '
        Me.TitreScore.AutoSize = True
        Me.TitreScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TitreScore.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitreScore.Location = New System.Drawing.Point(324, 9)
        Me.TitreScore.Name = "TitreScore"
        Me.TitreScore.Size = New System.Drawing.Size(157, 45)
        Me.TitreScore.TabIndex = 5
        Me.TitreScore.Text = "SCORES"
        '
        'ListBoxScore
        '
        Me.ListBoxScore.BackColor = System.Drawing.SystemColors.Window
        Me.ListBoxScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.ListBoxScore.FormattingEnabled = True
        Me.ListBoxScore.ItemHeight = 20
        Me.ListBoxScore.Location = New System.Drawing.Point(207, 76)
        Me.ListBoxScore.Name = "ListBoxScore"
        Me.ListBoxScore.Size = New System.Drawing.Size(528, 244)
        Me.ListBoxScore.TabIndex = 6
        '
        'ButtonRetour
        '
        Me.ButtonRetour.BackColor = System.Drawing.Color.LavenderBlush
        Me.ButtonRetour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonRetour.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRetour.Image = Global.MEMORY.My.Resources.Resources.iconRetour
        Me.ButtonRetour.Location = New System.Drawing.Point(14, 8)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(54, 46)
        Me.ButtonRetour.TabIndex = 4
        Me.ButtonRetour.Text = " "
        Me.ButtonRetour.UseVisualStyleBackColor = False
        '
        'ButtonTrier
        '
        Me.ButtonTrier.BackColor = System.Drawing.Color.LavenderBlush
        Me.ButtonTrier.Location = New System.Drawing.Point(12, 165)
        Me.ButtonTrier.Name = "ButtonTrier"
        Me.ButtonTrier.Size = New System.Drawing.Size(71, 71)
        Me.ButtonTrier.TabIndex = 7
        Me.ButtonTrier.Text = "<"
        Me.ButtonTrier.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Trier"
        '
        'FormScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonTrier)
        Me.Controls.Add(Me.ListBoxScore)
        Me.Controls.Add(Me.TitreScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonInfos)
        Me.Controls.Add(Me.ComboBoxNomJoueur)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.ListBoxNom)
        Me.Name = "FormScore"
        Me.Text = "Score"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxNomJoueur As ComboBox
    Friend WithEvents ButtonInfos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxNom As ListBox
    Friend WithEvents ButtonRetour As Button
    Friend WithEvents TitreScore As Label
    Friend WithEvents ListBoxScore As ListBox
    Friend WithEvents ButtonTrier As Button
    Friend WithEvents Label2 As Label
End Class
