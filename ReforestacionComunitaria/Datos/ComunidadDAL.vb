Imports System.Data.SqlClient
Imports ReforestacionComunitaria.ReforestacionComunitaria.Modelos

Public Class ComunidadDAL

    ' Obtener todas las comunidades
    Public Shared Function ObtenerTodas() As List(Of ComunidadPa)
        Dim lista As New List(Of ComunidadPa)
        Dim query As String = "SELECT * FROM Comunidad"
        Using con As New SqlConnection(Conexion.Cadena)
            Using cmd As New SqlCommand(query, con)
                con.Open()
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        lista.Add(New ComunidadPa With {
                            .Id = CInt(reader("Id")),
                            .Nombre = reader("Nombre").ToString(),
                            .Latitud = CDec(reader("Latitud")),
                            .Longitud = CDec(reader("Longitud")),
                            .Descripcion = reader("Descripcion").ToString(),
                            .FechaCreacion = CDate(reader("FechaCreacion")),
                            .FechaActualizacion = CDate(reader("FechaActualizacion"))
                        })
                    End While
                End Using
            End Using
        End Using
        Return lista
    End Function

    ' Insertar nueva comunidad
    Public Shared Sub Insertar(comunidad As ComunidadPa)
        Dim query As String = "INSERT INTO Comunidad (Nombre, Latitud, Longitud, Descripcion, FechaCreacion, FechaActualizacion) " &
                              "VALUES (@Nombre, @Latitud, @Longitud, @Descripcion, GETDATE(), GETDATE())"
        Using con As New SqlConnection(Conexion.Cadena)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Nombre", comunidad.Nombre)
                cmd.Parameters.AddWithValue("@Latitud", comunidad.Latitud)
                cmd.Parameters.AddWithValue("@Longitud", comunidad.Longitud)
                cmd.Parameters.AddWithValue("@Descripcion", comunidad.Descripcion)
                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Actualizar comunidad existente
    Public Shared Sub Actualizar(comunidad As ComunidadPa)
        Dim query As String = "UPDATE Comunidad SET " &
                              "Nombre = @Nombre, " &
                              "Latitud = @Latitud, " &
                              "Longitud = @Longitud, " &
                              "Descripcion = @Descripcion, " &
                              "FechaActualizacion = GETDATE() " &
                              "WHERE Id = @Id"
        Using con As New SqlConnection(Conexion.Cadena)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Nombre", comunidad.Nombre)
                cmd.Parameters.AddWithValue("@Latitud", comunidad.Latitud)
                cmd.Parameters.AddWithValue("@Longitud", comunidad.Longitud)
                cmd.Parameters.AddWithValue("@Descripcion", comunidad.Descripcion)
                cmd.Parameters.AddWithValue("@Id", comunidad.Id)
                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Eliminar comunidad por ID
    Public Shared Sub Eliminar(id As Integer)
        Dim query As String = "DELETE FROM Comunidad WHERE Id = @Id"
        Using con As New SqlConnection(Conexion.Cadena)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Id", id)
                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Obtener una sola comunidad por ID
    Public Shared Function ObtenerPorId(id As Integer) As ComunidadPa
        Dim comunidad As ComunidadPa = Nothing
        Dim query As String = "SELECT * FROM Comunidad WHERE Id = @Id"
        Using con As New SqlConnection(Conexion.Cadena)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Id", id)
                con.Open()
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        comunidad = New ComunidadPa With {
                            .Id = CInt(reader("Id")),
                            .Nombre = reader("Nombre").ToString(),
                            .Latitud = CDec(reader("Latitud")),
                            .Longitud = CDec(reader("Longitud")),
                            .Descripcion = reader("Descripcion").ToString(),
                            .FechaCreacion = CDate(reader("FechaCreacion")),
                            .FechaActualizacion = CDate(reader("FechaActualizacion"))
                        }
                    End If
                End Using
            End Using
        End Using
        Return comunidad
    End Function

    Public Shared Function ObtenerNombrePorId(id As Integer) As String
        Dim query As String = "SELECT Nombre FROM Comunidad WHERE Id = @Id"
        Using con As New SqlConnection(Conexion.Cadena)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Id", id)
                con.Open()
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    Return result.ToString()
                Else
                    Return String.Empty
                End If
            End Using
        End Using
    End Function



End Class
