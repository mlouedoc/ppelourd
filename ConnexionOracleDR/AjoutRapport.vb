Public Class AjoutRapport

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    'Dim connString As String = "DSN=ORA11;Uid=sc_gsb;Pwd=estran;"
    Dim donnee As DataTable
    Dim idmedicament As String
    Dim idpraticien As Integer = SelectionMedecin.idPraticien
    Dim idvisiteur As Integer = connexion.idvisiteur


    Private Sub Form4_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'FERME DE SERVEUR
        'connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.23.80)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));Uid=MESGUEN3;Pwd=Estran;"
        'SERVEUR DE TEST
        'connString = "Driver={Microsoft ODBC for Oracle};CONNECTSTRING=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.220.100)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORA20)));Uid=SCOTT;Pwd=tiger;"
        'connString = "DSN=ora19;Uid=ppe;Pwd=estran;"
        'connString = "DSN=FERME;Uid=SCOTT;Pwd=tiger;"

        'myConnection.ConnectionString = connString

        'Try
        '    myConnection.Open()
        'Catch ex As Odbc.OdbcException
        '    MessageBox.Show(ex.Message)
        'End Try

        ListMedPrescrit.Text = "Selectionnez un medicament"



        Dim query As String = "SELECT nommedicament, idmedicament FROM medicament"


        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, connexion.myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)



        Me.ListMedPrescrit.DataSource = donnee
        Me.ListMedPrescrit.DisplayMember = "nommedicament"
        Me.ListMedPrescrit.ValueMember = "idmedicament"


    End Sub


    Private Sub ajouterMed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ajouterMed.Click
        Dim quantite As Integer = QuantiteMed.Value

        ListMedicament.Items.Add(ListMedPrescrit.SelectedValue & " | " & ListMedPrescrit.Text & " | " & quantite)
    End Sub

    Private Sub validerRapport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles validerRapport.Click
        'connString = "DSN=ora19;Uid=ppe;Pwd=estran;"
        'Dim query2 As String = "Insert all into rapport (idRap,rapport_visite,date_visite,id_visiteur,id_praticien) values(seqrapport.nextval, '" & TextRapport.Text & "',(select TO_DATE(SYSDATE, 'DD/MM/YYYY')from dual),'" & idvisiteur & "','" & idpraticien & "') "
        Dim query2 As String = "Insert all into rapport (idRapport,rapport_visite,date_visite,id_visiteur,id_praticien) values(rapport_id.nextval, '" & TextRapport.Text & "',sysdate ,'" & idvisiteur & "','" & idpraticien & "') "


        Dim tableau() As String

        For Each valeur As [Object] In ListMedicament.Items
            tableau = Split(valeur, "|")

            query2 = query2 & " into quantite (id_rapport,id_medicament,quantite) values (rapport_id.currval, '" & tableau(0) & "', '" & tableau(2) & "') "

        Next
        query2 = query2 & " select * from dual"
        myCommand.Connection = connexion.myConnection
        myCommand.CommandText = query2
        myReader = myCommand.ExecuteReader
        MessageBox.Show("Rapport validé")

        accueil.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        PictureBox1.Image = Image.FromFile("C:\Users\games\3D Objects\gsb.png")
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub ListMedPrescrit_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListMedPrescrit.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        SelectionMedecin.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        ListMedicament.Items.Remove(ListMedicament.SelectedItem)
    End Sub
End Class