Imports System.Data.SqlClient

Imports ReforestacionComunitaria.ReforestacionComunitaria.Modelos

Public Class ComunidadDAL
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

    Public Shared Sub Insertar(comunidad As Comunidad)
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
End Class
