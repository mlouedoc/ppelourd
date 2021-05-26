<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectionMedecin
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
        Me.validerPraticien = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listepraticien = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'validerPraticien
        '
        Me.validerPraticien.Location = New System.Drawing.Point(60, 189)
        Me.validerPraticien.Margin = New System.Windows.Forms.Padding(2)
        Me.validerPraticien.Name = "validerPraticien"
        Me.validerPraticien.Size = New System.Drawing.Size(103, 37)
        Me.validerPraticien.TabIndex = 1
        Me.validerPraticien.Text = "Valider"
        Me.validerPraticien.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sélectionnez un praticien"
        '
        'listepraticien
        '
        Me.listepraticien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.listepraticien.FormattingEnabled = True
        Me.listepraticien.Location = New System.Drawing.Point(152, 89)
        Me.listepraticien.Margin = New System.Windows.Forms.Padding(2)
        Me.listepraticien.Name = "listepraticien"
        Me.listepraticien.Size = New System.Drawing.Size(180, 21)
        Me.listepraticien.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(202, 189)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 37)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SelectionMedecin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(353, 263)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.listepraticien)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.validerPraticien)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "SelectionMedecin"
        Me.Text = "Sélectionnez un visiteur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents validerPraticien As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents listepraticien As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
