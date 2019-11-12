Imports CapaDatos
Imports CapaEntidad
Public Class negP2
    Dim cod As New entP2
    Dim coddat As New datP2
    Public Function mostrarTelefono(cod) As DataTable
        Return coddat.mostrarTelefono(cod)
    End Function
End Class
