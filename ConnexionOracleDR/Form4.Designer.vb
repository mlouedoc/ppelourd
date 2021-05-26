<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
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
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'validerRapport
        '
        Me.validerRapport.Location = New System.Drawing.Point(256, 471)
        Me.validerRapport.Margin = New System.Windows.Forms.Padding(2)
        Me.validerRapport.Name = "validerRapport"
        Me.validerRapport.Size = New System.Drawing.Size(103, 37)
        Me.validerRapport.TabIndex = 2
        Me.validerRapport.Text = "Valider"
        Me.validerRapport.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 290)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ecrivez votre rapport"
        '
        'QuantiteMed
        '
        Me.QuantiteMed.Location = New System.Drawing.Point(187, 154)
        Me.QuantiteMed.Margin = New System.Windows.Forms.Padding(2)
        Me.QuantiteMed.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.QuantiteMed.Name = "QuantiteMed"
        Me.QuantiteMed.Size = New System.Drawing.Size(90, 20)
        Me.QuantiteMed.TabIndex = 5
        '
        'TextRapport
        '
        Me.TextRapport.Location = New System.Drawing.Point(37, 314)
        Me.TextRapport.Margin = New System.Windows.Forms.Padding(2)
        Me.TextRapport.Multiline = True
        Me.TextRapport.Name = "TextRapport"
        Me.TextRapport.Size = New System.Drawing.Size(547, 141)
        Me.TextRapport.TabIndex = 6
        '
        'ListMedPrescrit
        '
        Me.ListMedPrescrit.FormattingEnabled = True
        Me.ListMedPrescrit.Location = New System.Drawing.Point(61, 154)
        Me.ListMedPrescrit.Margin = New System.Windows.Forms.Padding(2)
        Me.ListMedPrescrit.Name = "ListMedPrescrit"
        Me.ListMedPrescrit.Size = New System.Drawing.Size(92, 21)
        Me.ListMedPrescrit.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(378, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Prescriptions"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 139)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Quantitée"
        '
        'ajouterMed
        '
        Me.ajouterMed.Location = New System.Drawing.Point(118, 179)
        Me.ajouterMed.Margin = New System.Windows.Forms.Padding(2)
        Me.ajouterMed.Name = "ajouterMed"
        Me.ajouterMed.Size = New System.Drawing.Size(103, 37)
        Me.ajouterMed.TabIndex = 10
        Me.ajouterMed.Text = "Ajouter"
        Me.ajouterMed.UseVisualStyleBackColor = True
        '
        'ListMedicament
        '
        Me.ListMedicament.FormattingEnabled = True
        Me.ListMedicament.Location = New System.Drawing.Point(381, 139)
        Me.ListMedicament.Margin = New System.Windows.Forms.Padding(2)
        Me.ListMedicament.Name = "ListMedicament"
        Me.ListMedicament.Size = New System.Drawing.Size(203, 95)
        Me.ListMedicament.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 139)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Medicaments"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(259, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 70)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 531)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form4"
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
End Class
