Public Class SelectionMedecin

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    'Dim connString As String
    Dim donnee As DataTable
    'Public idvisiteur As Integer
    Public idPraticien As Integer
    'Public connString = "DSN=ora19;Uid=ppe;Pwd=estran;"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        listepraticien.Text = "Selectionnez un praticien"



        Dim queryPraticien As String = "SELECT idpraticien, (prenom ||' '||nom) nom_prenom_praticien FROM PRATICIEN"


        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(queryPraticien, connexion.myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)



        Me.listepraticien.DataSource = donnee
        Me.listepraticien.DisplayMember = "nom_prenom_praticien"
        Me.listepraticien.ValueMember = "idpraticien"


    End Sub



    Private Sub validerPraticien_Click() Handles validerPraticien.Click

        Dim idchoixPraticien As String = listepraticien.SelectedValue
        idPraticien = idchoixPraticien

        AjoutRapport.Show()
        Me.Hide()

    End Sub

    Private Sub listevisiteur_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        accueil.Show()
        Me.Hide()
    End Sub
End Class