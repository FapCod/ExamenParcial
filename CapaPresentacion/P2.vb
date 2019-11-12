Imports CapaEntidad
Imports CapaNegocio
Public Class P2


    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        Dim objp2 As New entP2
        objp2._codp2 = txtCodigoP2.Text
        Dim conexion As New negP2
        DataGridView1.DataSource = conexion.mostrarTelefono(objp2)
    End Sub
    Private Sub P2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
