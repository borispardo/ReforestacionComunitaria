﻿Imports System.Configuration
Imports System.Data.SqlClient

Public Class Conexion
    Public Shared Function ObtenerConexion() As SqlConnection
        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("ConexionCatalogo").ConnectionString)
        Return conexion
    End Function
End Class
