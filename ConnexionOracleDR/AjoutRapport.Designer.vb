<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjoutRapport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AjoutRapport))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.validerRapport = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QuantiteMed = New System.Windows.Forms.NumericUpDown()
        Me.TextRapport = New System.Windows.Forms.TextBox()
        Me.ListMedPrescrit = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ajouterMed = New System.Windows.Forms.Button()
        Me.ListMedicament = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.QuantiteMed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(231, 109)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox1.TabIndex = 0
        '
        'validerRapport
        '
        Me.validerRapport.Location = New System.Drawing.Point(179, 578)
        Me.validerRapport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.validerRapport.Name = "validerRapport"
        Me.validerRapport.Size = New System.Drawing.Size(137, 46)
        Me.validerRapport.TabIndex = 2
        Me.validerRapport.Text = "Valider"
        Me.validerRapport.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 357)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ecrivez votre rapport"
        '
        'QuantiteMed
        '
        Me.QuantiteMed.Location = New System.Drawing.Point(249, 190)
        Me.QuantiteMed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QuantiteMed.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.QuantiteMed.Name = "QuantiteMed"
        Me.QuantiteMed.Size = New System.Drawing.Size(120, 22)
        Me.QuantiteMed.TabIndex = 5
        '
        'TextRapport
        '
        Me.TextRapport.Location = New System.Drawing.Point(49, 386)
        Me.TextRapport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextRapport.Multiline = True
        Me.TextRapport.Name = "TextRapport"
        Me.TextRapport.Size = New System.Drawing.Size(728, 173)
        Me.TextRapport.TabIndex = 6
        '
        'ListMedPrescrit
        '
        Me.ListMedPrescrit.FormattingEnabled = True
        Me.ListMedPrescrit.Location = New System.Drawing.Point(81, 190)
        Me.ListMedPrescrit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListMedPrescrit.Name = "ListMedPrescrit"
        Me.ListMedPrescrit.Size = New System.Drawing.Size(121, 24)
        Me.ListMedPrescrit.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(504, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Prescriptions"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(264, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Quantitée"
        '
        'ajouterMed
        '
        Me.ajouterMed.Location = New System.Drawing.Point(157, 220)
        Me.ajouterMed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ajouterMed.Name = "ajouterMed"
        Me.ajouterMed.Size = New System.Drawing.Size(137, 46)
        Me.ajouterMed.TabIndex = 10
        Me.ajouterMed.Text = "Ajouter"
        Me.ajouterMed.UseVisualStyleBackColor = True
        '
        'ListMedicament
        '
        Me.ListMedicament.FormattingEnabled = True
        Me.ListMedicament.ItemHeight = 16
        Me.ListMedicament.Location = New System.Drawing.Point(508, 171)
        Me.ListMedicament.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListMedicament.Name = "ListMedicament"
        Me.ListMedicament.Size = New System.Drawing.Size(269, 116)
        Me.ListMedicament.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Medicaments"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(370, 38)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 89)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(508, 578)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 46)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(157, 281)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 46)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Supprimer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AjoutRapport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(849, 654)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListMedicament)
        Me.Controls.Add(Me.ajouterMed)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListMedPrescrit)
        Me.Controls.Add(Me.TextRapport)
        Me.Controls.Add(Me.QuantiteMed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.validerRapport)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AjoutRapport"
        Me.Text = "Sélectionnez un praticien"
        CType(Me.QuantiteMed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents validerRapport As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents QuantiteMed As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextRapport As System.Windows.Forms.TextBox
    Friend WithEvents ListMedPrescrit As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ajouterMed As System.Windows.Forms.Button
    Friend WithEvents ListMedicament As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
