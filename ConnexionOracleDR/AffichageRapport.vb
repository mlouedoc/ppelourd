Imports System.Data.SqlClient

Public Class AffichageRapport
    Dim annee As Integer = SelectionRapport.AnneeRapport.Value
    Dim mois As Integer = SelectionRapport.listeMois.Text
    Dim moisPlusUn As String = SelectionRapport.listeMois.Text + 1
    Dim idvisiteur As Integer = connexion.idvisiteur

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable




    Private Sub AffichageRapport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load, Button1.Click



        If moisPlusUn < 10 Then
            moisPlusUn = "0" & moisPlusUn.ToString
        End If
        If mois = "09" Then
            moisPlusUn = "10"
        End If
        If mois = "12" Then
            mois = "01"
            annee = annee + 1
        End If


        Dim query As String = "select distinct Praticien.nom, praticien.prenom, rapport.date_visite, rapport.rapport_visite, rapport.idrapport from praticien, medicament, quantite, rapport where medicament.idmedicament = quantite.id_medicament AND praticien.idpraticien = rapport.id_praticien AND rapport.idrapport = quantite.id_rapport AND rapport.id_visiteur = '" & idvisiteur & "' AND date_visite between TO_DATE('01/" & mois & "/" & annee & "','DD/MM/YYYY') AND TO_DATE('01/" & moisPlusUn & "/" & annee & "','DD/MM/YYYY');"
        'Dim Element As New ListViewItem



        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, connexion.myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        Dim boucle As Integer = donnee.Rows.Count


        'Dim ligne As DataRow
        'Dim column As DataColumn
        ''Dim sLines As String

        'For Each ligne In donnee.Rows
        '    'sLines = ""
        '    For Each column In donnee.Columns
        '        Element.SubItems.Add(ligne(column).ToString)
        '        'sLines += ligne(column).ToString & " - "
        '    Next

        '    ' MessageBox.Show(sLines)
        'Next
        'ListView1.Items.Add(Element)
        SocGrid.DataSource = donnee


    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles MyBase.Click, SocGrid.Click
        'SelectionRapport.Show()
        'Me.Hide()

        Dim query As String = "select distinct nommedicament, quantite from medicament, quantite, rapport where medicament.idmedicament = quantite.id_medicament  AND quantite.id_rapport = rapport.idrapport AND rapport.idrapport = '" & SocGrid.CurrentRow.Cells(4).Value.ToString() & "';"
        'Dim Element As New ListViewItem
        Dim compteur = 0
        Dim medicament As String = ""



        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, connexion.myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        Dim boucle As Integer = donnee.Rows.Count

        While compteur < boucle
            medicament = medicament & " " & donnee.Rows(compteur).Item("nommedicament") & " : " & donnee.Rows(compteur).Item("quantite") & vbCrLf
            compteur = compteur + 1
        End While

        Dim form As New Form2

        form.TextBox1.Text = SocGrid.CurrentRow.Cells(1).Value.ToString() & "  " & SocGrid.CurrentRow.Cells(0).Value.ToString()
        form.TextBox1.ReadOnly = True

        form.TextBox2.Text = medicament
        form.TextBox2.ReadOnly = True

        form.TextBox3.Text = SocGrid.CurrentRow.Cells(2).Value.ToString()
        form.TextBox3.ReadOnly = True

        form.TextRapport.Text = SocGrid.CurrentRow.Cells(3).Value.ToString()
        form.TextRapport.ReadOnly = True
        form.ShowDialog()
    End Sub

    
    
    

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        SelectionRapport.Show()
    End Sub

    Private Sub SocGrid_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SocGrid.CellContentClick

    End Sub
End Class