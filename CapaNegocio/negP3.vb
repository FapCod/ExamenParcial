Imports CapaDatos
Imports CapaEntidad
Public Class negP3
    Dim cod As New entP3
    Dim coddat As New datP3
    Public Function mostrarSaldoCliente(cod) As DataTable
        Return coddat.mostrarSaldoCliente(cod)
    End Function
End Class
