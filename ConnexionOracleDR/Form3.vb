Public Class Form3

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable
    Public idpraticien As String





    Private Sub Form3_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'FERME DE SERVEUR
        'connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.23.80)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));Uid=MESGUEN3;Pwd=Estran;"
        'SERVEUR DE TEST
        'connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.220.100)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORA20)));Uid=SCOTT;Pwd=tiger;"
        connString = "DSN=ora19;Uid=ppe;Pwd=estran;"
        'connString = "DSN=FERME;Uid=SCOTT;Pwd=tiger;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        listepraticien.Text = "Selectionnez un praticien"



        Dim query As String = "SELECT idpraticien, (prenom ||' '||nom) nom_prenom_praticien FROM PRATICIEN"


        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)



        Me.listepraticien.DataSource = donnee
        Me.listepraticien.DisplayMember = "nom_prenom_praticien"
        Me.listepraticien.ValueMember = "idpraticien"




    End Sub


    Private Sub validervisiteur_Click() Handles validervisiteur.Click
        Dim idchoix As String = listepraticien.SelectedValue
        idpraticien = idchoix
        Form4.Show()

    End Sub

    Private Sub listepraticien_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles listepraticien.SelectedIndexChanged

    End Sub
End Class