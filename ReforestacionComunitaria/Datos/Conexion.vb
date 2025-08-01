Imports System.Configuration
Imports System.Data.SqlClient

Public Class Conexion
    Public Shared ReadOnly Property Cadena As String
        Get
            Return "Data Source=.\SQLEXPRESS;Initial Catalog=TuBaseDeDatos;Integrated Security=True"
        End Get
    End Property
End Class

