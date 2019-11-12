Imports CapaDatos
Imports CapaEntidad
Public Class negP4
    Dim cod As New entP4
    Dim coddat As New datP4
    Public Function mostrarClientePorDistrito(cod) As DataTable
        Return coddat.mostrarClientePorDistrito(cod)
    End Function
End Class