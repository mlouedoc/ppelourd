Public Class Form1

    Dim table As New DataTable("Table")

    'Dim annee As Integer = SelectionRapport.AnneeRapport.Value
    'Dim mois As String = SelectionRapport.listeMois.Text
    'Dim moisPlusUn As String = SelectionRapport.listeMois.Text
    Dim idvisiteur As Integer = connexion.idvisiteur

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable


    'Dim conn As SqlConnection
    'Dim cmd As SqlCommand
    'Dim da As SqlDataAdapter
    'Dim ds As DataSet
    'Dim itemcoll(100) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If moisPlusUn < 10 Then
        '    moisPlusUn = "0" & moisPlusUn.ToString
        'End If
        'If mois = "09" Then
        '    moisPlusUn = "10"
        'End If
        'If mois = "12" Then
        '    mois = "01"
        '    annee = annee + 1
        'End If

        Dim query As String = "select distinct Praticien.nom, praticien.prenom, rapport.date_visite, rapport.rapport_visite from praticien, medicament, quantite, rapport where medicament.idmedicament = quantite.id_medicament AND praticien.idpraticien = rapport.id_praticien AND rapport.idrapport = quantite.id_rapport AND rapport.id_praticien = '" & idvisiteur & "';"
        Dim Element As New ListViewItem



        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, connexion.myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)


        ' now set the datagridview datasource equals to your datatable name
        DataGridView1.DataSource = donnee

    End Sub



    'Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click

    '    Dim form As New Form2

    '    form.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
    '    form.TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
    '    form.TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
    '    form.TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()

    '    form.ShowDialog()
    'End Sub

End Class