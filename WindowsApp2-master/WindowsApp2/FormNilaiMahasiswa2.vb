Imports System.Data.SqlClient
Public Class FormNilaiMahasiswa2
    Private Sub FormNilaiMahasiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        DA = New SqlDataAdapter("select * from TBL_User where Username like '%" & FormMahasiswa2.Label5.Text & "%'", CONN)
        DS = New DataSet
        DA.Fill(DS, "ketemu")
        DataGridView1.DataSource = DS.Tables("ketemu")
        DataGridView1.ReadOnly = True
    End Sub
End Class