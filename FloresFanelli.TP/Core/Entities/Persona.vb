Namespace Entities

    Public Class Persona

        Property IdNegocio As Integer
        Property Nombre As String
        Property Apellido As String
        Property DNI As Double
        Property Telefonos As List(Of Telefono)
        Property Email As List(Of Email)
        Property Sufijo As Integer

    End Class

    Public Enum Options As Integer

        SR = 1
        SRA = 2

    End Enum

End Namespace