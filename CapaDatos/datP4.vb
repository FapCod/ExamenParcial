Imports CapaDatos
Imports CapaEntidad
Imports System.Data.SqlClient

Public Class datP4
    Inherits datConexion
    Public Function mostrarClientePorDistrito(cod As entP4) As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "PAF_consultar_clientes_por_distrito"
                Command.Parameters.AddWithValue("@vch_cliedireccion", cod._codp4)
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
