Imports System.Data.SqlClient
Public MustInherit Class datConexion
    Private cadena_conexion As String
    Private cadena As String
    Protected Sub New()
        cadena_conexion = "Data Source=FAPCOD\SQLEXPRESS;Initial Catalog=eurekabank;Integrated Security=True"
    End Sub
    Protected Function ObtenerConexion() As SqlConnection
        Return New SqlConnection(cadena_conexion)
    End Function
    Protected Function ObtenerConexionU() As SqlConnection
        Return New SqlConnection(cadena_conexion)
        Console.Write(cadena)
    End Function

End Class