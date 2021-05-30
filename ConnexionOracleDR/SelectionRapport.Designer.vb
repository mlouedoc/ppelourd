<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectionRapport
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
        Me.listeMois = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AnneeRapport = New System.Windows.Forms.NumericUpDown()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.AnneeRapport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listeMois
        '
        Me.listeMois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.listeMois.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listeMois.FormattingEnabled = True
        Me.listeMois.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.listeMois.Location = New System.Drawing.Point(69, 131)
        Me.listeMois.Margin = New System.Windows.Forms.Padding(2)
        Me.listeMois.Name = "listeMois"
        Me.listeMois.Size = New System.Drawing.Size(155, 21)
        Me.listeMois.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(82, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 70)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Afficher vos activités"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Mois : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(275, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Année : "
        '
        'AnneeRapport
        '
        Me.AnneeRapport.Location = New System.Drawing.Point(327, 131)
        Me.AnneeRapport.Margin = New System.Windows.Forms.Padding(2)
        Me.AnneeRapport.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.AnneeRapport.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.AnneeRapport.Name = "AnneeRapport"
        Me.AnneeRapport.Size = New System.Drawing.Size(90, 20)
        Me.AnneeRapport.TabIndex = 12
        Me.AnneeRapport.Value = New Decimal(New Integer() {2021, 0, 0, 0})
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(254, 298)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 70)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "retour"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SelectionRapport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(465, 445)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.AnneeRapport)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.listeMois)
        Me.Name = "SelectionRapport"
        Me.Text = "SelectionVisiteur"
        CType(Me.AnneeRapport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listeMois As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AnneeRapport As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
