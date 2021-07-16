<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOption
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
        Me.TitreOption = New System.Windows.Forms.Label()
        Me.GroupBoxNiveau = New System.Windows.Forms.GroupBox()
        Me.RadioButtonDur = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFacile = New System.Windows.Forms.RadioButton()
        Me.GroupBoxSave = New System.Windows.Forms.GroupBox()
        Me.TextBoxFilePath = New System.Windows.Forms.TextBox()
        Me.GroupBoxPause = New System.Windows.Forms.GroupBox()
        Me.RadioButtonPause = New System.Windows.Forms.RadioButton()
        Me.ButtonEnregistrer = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelSec = New System.Windows.Forms.Label()
        Me.TextBoxTemps = New System.Windows.Forms.TextBox()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.RadioButtonNormal = New System.Windows.Forms.RadioButton()
        Me.GroupBoxNiveau.SuspendLayout()
        Me.GroupBoxSave.SuspendLayout()
        Me.GroupBoxPause.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitreOption
        '
        Me.TitreOption.AutoSize = True
        Me.TitreOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TitreOption.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitreOption.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TitreOption.Location = New System.Drawing.Point(303, 13)
        Me.TitreOption.Name = "TitreOption"
        Me.TitreOption.Size = New System.Drawing.Size(155, 45)
        Me.TitreOption.TabIndex = 0
        Me.TitreOption.Text = "OPTION"
        '
        'GroupBoxNiveau
        '
        Me.GroupBoxNiveau.Controls.Add(Me.RadioButtonNormal)
        Me.GroupBoxNiveau.Controls.Add(Me.RadioButtonDur)
        Me.GroupBoxNiveau.Controls.Add(Me.RadioButtonFacile)
        Me.GroupBoxNiveau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBoxNiveau.Location = New System.Drawing.Point(22, 91)
        Me.GroupBoxNiveau.Name = "GroupBoxNiveau"
        Me.GroupBoxNiveau.Size = New System.Drawing.Size(746, 135)
        Me.GroupBoxNiveau.TabIndex = 2
        Me.GroupBoxNiveau.TabStop = False
        Me.GroupBoxNiveau.Text = "Niveau"
        '
        'RadioButtonDur
        '
        Me.RadioButtonDur.AutoSize = True
        Me.RadioButtonDur.Location = New System.Drawing.Point(535, 51)
        Me.RadioButtonDur.Name = "RadioButtonDur"
        Me.RadioButtonDur.Size = New System.Drawing.Size(60, 24)
        Me.RadioButtonDur.TabIndex = 2
        Me.RadioButtonDur.TabStop = True
        Me.RadioButtonDur.Text = "Dur"
        Me.RadioButtonDur.UseVisualStyleBackColor = True
        '
        'RadioButtonFacile
        '
        Me.RadioButtonFacile.AutoSize = True
        Me.RadioButtonFacile.Location = New System.Drawing.Point(114, 51)
        Me.RadioButtonFacile.Name = "RadioButtonFacile"
        Me.RadioButtonFacile.Size = New System.Drawing.Size(76, 24)
        Me.RadioButtonFacile.TabIndex = 0
        Me.RadioButtonFacile.TabStop = True
        Me.RadioButtonFacile.Text = "Facile"
        Me.RadioButtonFacile.UseVisualStyleBackColor = True
        '
        'GroupBoxSave
        '
        Me.GroupBoxSave.Controls.Add(Me.ButtonSearch)
        Me.GroupBoxSave.Controls.Add(Me.TextBoxFilePath)
        Me.GroupBoxSave.ForeColor = System.Drawing.Color.Black
        Me.GroupBoxSave.Location = New System.Drawing.Point(506, 249)
        Me.GroupBoxSave.Name = "GroupBoxSave"
        Me.GroupBoxSave.Size = New System.Drawing.Size(262, 113)
        Me.GroupBoxSave.TabIndex = 4
        Me.GroupBoxSave.TabStop = False
        Me.GroupBoxSave.Text = "Save"
        '
        'TextBoxFilePath
        '
        Me.TextBoxFilePath.BackColor = System.Drawing.Color.LavenderBlush
        Me.TextBoxFilePath.Location = New System.Drawing.Point(6, 45)
        Me.TextBoxFilePath.Name = "TextBoxFilePath"
        Me.TextBoxFilePath.Size = New System.Drawing.Size(210, 26)
        Me.TextBoxFilePath.TabIndex = 8
        '
        'GroupBoxPause
        '
        Me.GroupBoxPause.Controls.Add(Me.RadioButtonPause)
        Me.GroupBoxPause.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBoxPause.Location = New System.Drawing.Point(238, 249)
        Me.GroupBoxPause.Name = "GroupBoxPause"
        Me.GroupBoxPause.Size = New System.Drawing.Size(262, 113)
        Me.GroupBoxPause.TabIndex = 5
        Me.GroupBoxPause.TabStop = False
        Me.GroupBoxPause.Text = "Pause"
        '
        'RadioButtonPause
        '
        Me.RadioButtonPause.AutoSize = True
        Me.RadioButtonPause.Location = New System.Drawing.Point(85, 51)
        Me.RadioButtonPause.Name = "RadioButtonPause"
        Me.RadioButtonPause.Size = New System.Drawing.Size(85, 24)
        Me.RadioButtonPause.TabIndex = 0
        Me.RadioButtonPause.TabStop = True
        Me.RadioButtonPause.Text = "Ajouter"
        Me.RadioButtonPause.UseVisualStyleBackColor = True
        '
        'ButtonEnregistrer
        '
        Me.ButtonEnregistrer.BackColor = System.Drawing.Color.LavenderBlush
        Me.ButtonEnregistrer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEnregistrer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.ButtonEnregistrer.Location = New System.Drawing.Point(22, 399)
        Me.ButtonEnregistrer.Name = "ButtonEnregistrer"
        Me.ButtonEnregistrer.Size = New System.Drawing.Size(746, 47)
        Me.ButtonEnregistrer.TabIndex = 6
        Me.ButtonEnregistrer.Text = "Enregistrer"
        Me.ButtonEnregistrer.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelSec)
        Me.GroupBox1.Controls.Add(Me.TextBoxTemps)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 249)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 113)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Temps"
        '
        'LabelSec
        '
        Me.LabelSec.AutoSize = True
        Me.LabelSec.Location = New System.Drawing.Point(156, 52)
        Me.LabelSec.Name = "LabelSec"
        Me.LabelSec.Size = New System.Drawing.Size(34, 20)
        Me.LabelSec.TabIndex = 1
        Me.LabelSec.Text = "sec"
        '
        'TextBoxTemps
        '
        Me.TextBoxTemps.Location = New System.Drawing.Point(17, 49)
        Me.TextBoxTemps.Name = "TextBoxTemps"
        Me.TextBoxTemps.Size = New System.Drawing.Size(124, 26)
        Me.TextBoxTemps.TabIndex = 0
        '
        'ButtonSearch
        '
        Me.ButtonSearch.BackColor = System.Drawing.Color.LavenderBlush
        Me.ButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonSearch.Image = Global.MEMORY.My.Resources.Resources.search
        Me.ButtonSearch.Location = New System.Drawing.Point(222, 45)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(34, 26)
        Me.ButtonSearch.TabIndex = 9
        Me.ButtonSearch.Text = " "
        Me.ButtonSearch.UseVisualStyleBackColor = False
        '
        'ButtonRetour
        '
        Me.ButtonRetour.BackColor = System.Drawing.Color.LavenderBlush
        Me.ButtonRetour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonRetour.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRetour.Image = Global.MEMORY.My.Resources.Resources.iconRetour
        Me.ButtonRetour.Location = New System.Drawing.Point(7, 13)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(47, 45)
        Me.ButtonRetour.TabIndex = 1
        Me.ButtonRetour.Text = " "
        Me.ButtonRetour.UseVisualStyleBackColor = False
        '
        'RadioButtonNormal
        '
        Me.RadioButtonNormal.AutoSize = True
        Me.RadioButtonNormal.Location = New System.Drawing.Point(322, 51)
        Me.RadioButtonNormal.Name = "RadioButtonNormal"
        Me.RadioButtonNormal.Size = New System.Drawing.Size(84, 24)
        Me.RadioButtonNormal.TabIndex = 3
        Me.RadioButtonNormal.TabStop = True
        Me.RadioButtonNormal.Text = "Normal"
        Me.RadioButtonNormal.UseVisualStyleBackColor = True
        '
        'FormOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(787, 458)
        Me.Controls.Add(Me.GroupBoxPause)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonEnregistrer)
        Me.Controls.Add(Me.GroupBoxSave)
        Me.Controls.Add(Me.GroupBoxNiveau)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.TitreOption)
        Me.Name = "FormOption"
        Me.Text = "Option"
        Me.GroupBoxNiveau.ResumeLayout(False)
        Me.GroupBoxNiveau.PerformLayout()
        Me.GroupBoxSave.ResumeLayout(False)
        Me.GroupBoxSave.PerformLayout()
        Me.GroupBoxPause.ResumeLayout(False)
        Me.GroupBoxPause.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitreOption As Label
    Friend WithEvents ButtonRetour As Button
    Friend WithEvents GroupBoxNiveau As GroupBox
    Friend WithEvents RadioButtonDur As RadioButton
    Friend WithEvents RadioButtonFacile As RadioButton
    Friend WithEvents GroupBoxSave As GroupBox
    Friend WithEvents GroupBoxPause As GroupBox
    Friend WithEvents RadioButtonPause As RadioButton
    Friend WithEvents ButtonEnregistrer As Button
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents TextBoxFilePath As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelSec As Label
    Friend WithEvents TextBoxTemps As TextBox
    Friend WithEvents RadioButtonNormal As RadioButton
End Class
