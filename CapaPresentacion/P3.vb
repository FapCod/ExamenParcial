Imports CapaEntidad
Imports CapaNegocio
Public Class P3

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        Dim objp3 As New entP3
        objp3._codp3 = txtCodigoP3.Text
        Dim conexion As New negP3
        DataGridView1.DataSource = conexion.mostrarSaldoCliente(objp3)
    End Sub

   
End Class