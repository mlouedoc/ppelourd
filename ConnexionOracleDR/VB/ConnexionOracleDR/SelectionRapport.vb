Public Class SelectionRapport

    Public Sub AnneeRapport_ValueChanged(sender As System.Object, e As System.EventArgs) Handles AnneeRapport.ValueChanged

    End Sub



    Private Sub listeMois_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles listeMois.SelectedIndexChanged
        
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        AffichageRapport.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        accueil.Show()
    End Sub
End Class