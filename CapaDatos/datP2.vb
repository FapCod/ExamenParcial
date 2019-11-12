
Imports CapaDatos
Imports CapaEntidad
Imports System.Data.SqlClient
Public Class datP2
    Inherits datConexion

    Public Function mostrarTelefono(cod As entP2) As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "PAF_consulta_telefono_de_cliente"
                Command.Parameters.AddWithValue("@chr_cliecodigo", cod._codp2)
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
