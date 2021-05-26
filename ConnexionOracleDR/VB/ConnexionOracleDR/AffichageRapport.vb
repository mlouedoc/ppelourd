Imports System.Data.SqlClient

Public Class AffichageRapport
    Dim annee As Integer = SelectionRapport.AnneeRapport.Value
    Dim mois As String = SelectionRapport.listeMois.Text
    Dim moisPlusUn As String = SelectionRapport.listeMois.Text + 1
    Dim idvisiteur As Integer = connexion.idvisiteur

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable


    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim itemcoll(100) As String


    Private Sub AffichageRapport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

        Dim query As String = "select distinct Praticien.nom, praticien.prenom, rapport.date_visite, rapport.rapport_visite from praticien, medicament, quantite, rapport where medicament.idmedicament = quantite.id_medicament AND praticien.idpraticien = rapport.id_praticien AND rapport.idrapport = quantite.id_rapport AND rapport.id_praticien = '" & idvisiteur & "';"
        Dim Element As New ListViewItem



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

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        SelectionRapport.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class