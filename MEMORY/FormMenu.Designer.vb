<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.ComboBoxNom = New System.Windows.Forms.ComboBox()
        Me.ButtonJouer = New System.Windows.Forms.Button()
        Me.ButtonOption = New System.Windows.Forms.Button()
        Me.ButtonScores = New System.Windows.Forms.Button()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.LabelTitre1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.LabelNom.Location = New System.Drawing.Point(34, 166)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(143, 21)
        Me.LabelNom.TabIndex = 0
        Me.LabelNom.Text = "Entrez votre nom"
        '
        'ComboBoxNom
        '
        Me.ComboBoxNom.BackColor = System.Drawing.Color.LavenderBlush
        Me.ComboBoxNom.FormattingEnabled = True
        Me.ComboBoxNom.Location = New System.Drawing.Point(183, 164)
        Me.ComboBoxNom.Name = "ComboBoxNom"
        Me.ComboBoxNom.Size = New System.Drawing.Size(149, 28)
        Me.ComboBoxNom.TabIndex = 1
        '
        'ButtonJouer
        '
        Me.ButtonJouer.BackColor = System.Drawing.Color.LavenderBlush
        Me.ButtonJouer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonJouer.Enabled = False
        Me.ButtonJouer.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonJouer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.ButtonJouer.Location = New System.Drawing.Point(135, 226)
        Me.ButtonJouer.Name = "ButtonJouer"
        Me.ButtonJouer.Size = New System.Drawing.Size(104, 33)
        Me.ButtonJouer.TabIndex = 2
        Me.ButtonJouer.Text = "Jouer"
        Me.ButtonJouer.UseVisualStyleBackColor = False
        '
        'ButtonOption
        '
        Me.ButtonOption.BackColor = System.Drawing.Color.LavenderBlush
        Me.ButtonOption.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonOption.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.ButtonOption.Location = New System.Drawing.Point(135, 265)
        Me.ButtonOption.Name = "ButtonOption"
        Me.ButtonOption.Size = New System.Drawing.Size(104, 33)
        Me.ButtonOption.TabIndex = 3
        Me.ButtonOption.Text = "Option"
        Me.ButtonOption.UseVisualStyleBackColor = False
        '
        'ButtonScores
        '
        Me.ButtonScores.BackColor = System.Drawing.Color.LavenderBlush
        Me.ButtonScores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonScores.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.ButtonScores.Location = New System.Drawing.Point(135, 304)
        Me.ButtonScores.Name = "ButtonScores"
        Me.ButtonScores.Size = New System.Drawing.Size(104, 33)
        Me.ButtonScores.TabIndex = 4
        Me.ButtonScores.Text = "Scores"
        Me.ButtonScores.UseVisualStyleBackColor = False
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.BackColor = System.Drawing.Color.LavenderBlush
        Me.ButtonQuitter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonQuitter.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuitter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.ButtonQuitter.Location = New System.Drawing.Point(135, 343)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(104, 35)
        Me.ButtonQuitter.TabIndex = 5
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = False
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.Location = New System.Drawing.Point(91, 48)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(232, 49)
        Me.LabelTitre.TabIndex = 6
        Me.LabelTitre.Text = "4 MEMORY"
        '
        'LabelTitre1
        '
        Me.LabelTitre1.AutoSize = True
        Me.LabelTitre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre1.Location = New System.Drawing.Point(187, 97)
        Me.LabelTitre1.Name = "LabelTitre1"
        Me.LabelTitre1.Size = New System.Drawing.Size(163, 20)
        Me.LabelTitre1.TabIndex = 7
        Me.LabelTitre1.Text = "a concentration game"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MEMORY.My.Resources.Resources.tete
        Me.PictureBox1.Location = New System.Drawing.Point(12, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 404)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelTitre1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ButtonScores)
        Me.Controls.Add(Me.ButtonOption)
        Me.Controls.Add(Me.ButtonJouer)
        Me.Controls.Add(Me.ComboBoxNom)
        Me.Controls.Add(Me.LabelNom)
        Me.Name = "FormMenu"
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelNom As Label
    Friend WithEvents ComboBoxNom As ComboBox
    Friend WithEvents ButtonJouer As Button
    Friend WithEvents ButtonOption As Button
    Friend WithEvents ButtonScores As Button
    Friend WithEvents ButtonQuitter As Button
    Friend WithEvents LabelTitre As Label
    Friend WithEvents LabelTitre1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
