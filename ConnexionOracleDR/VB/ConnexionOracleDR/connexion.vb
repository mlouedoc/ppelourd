Public Class connexion
    Public myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Public idvisiteur As String
    Public connString As String
    Dim donnee As DataTable

    Private Sub connexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        listevisiteur.Text = "Selectionnez un visiteur"



        Dim query As String = "SELECT idvisiteur, (prenom ||' '||nom) nom_prenom_visiteur FROM visiteur ORDER BY idvisiteur"



        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)



        Me.listevisiteur.DataSource = donnee
        Me.listevisiteur.DisplayMember = "nom_prenom_visiteur"
        Me.listevisiteur.ValueMember = "idvisiteur"


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim testConnexion As String
        Dim idchoixVisiteur As String = listevisiteur.SelectedValue
        Dim motDePasse = password.Text

        myConnection.Close()
        myConnection.Open()

        idvisiteur = idchoixVisiteur

        If password.Text = "" Then
            password.Text = " "
        End If


        testConnexion = "SELECT count(*) from visiteur where idvisiteur = '" & idvisiteur & "' AND PWD = '" & motDePasse & "'"

        myCommand.Connection = myConnection
        myCommand.CommandText = testConnexion
        myReader = myCommand.ExecuteReader

        While myReader.Read
            If myReader.GetValue(0) > 0 Then
                accueil.Show()
                Me.Hide()
            Else
                MessageBox.Show("Mot de passe incorrect")
            End If
        End While
    End Sub


    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles password.TextChanged

    End Sub
End Class