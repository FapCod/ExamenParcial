Imports CapaEntidad
Imports CapaNegocio
Public Class P4

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        Dim objp4 As New entP4
        objp4._codp4 = txtCodigoP4.Text
        Dim conexion As New negP4
        DataGridView1.DataSource = conexion.mostrarClientePorDistrito(objp4)
    End Sub
End Class