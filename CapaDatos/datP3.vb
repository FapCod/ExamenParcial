Imports CapaDatos
Imports CapaEntidad
Imports System.Data.SqlClient
Public Class datP3
    Inherits datConexion

    Public Function mostrarSaldoCliente(cod As entP3) As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "PFA_consulta_saldo_de_cuenta"
                Command.Parameters.AddWithValue("@cod_cliecodigo", cod._codp3)
                Command.CommandType = CommandType.StoredProcedure
                Dim dt1 As New DataTable
                dt1.Load(Command.ExecuteReader())
                If Command.ExecuteNonQuery Then
                    Return dt1
                Else
                    Return Nothing
                End If
            End Using
        End Using
        Return Nothing
    End Function
End Class
