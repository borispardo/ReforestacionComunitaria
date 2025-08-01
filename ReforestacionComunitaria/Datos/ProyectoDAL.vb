Imports System.Data.SqlClient

Public Class ProyectoDAL
    Public Shared Function ObtenerTodos() As List(Of ProyectoRe)
        Dim lista As New List(Of ProyectoRe)
        Dim query As String = "SELECT * FROM ProyectoReforestacion"
        Using con As New SqlConnection(Conexion.Cadena)
            Using cmd As New SqlCommand(query, con)
                con.Open()
                Dim reader = cmd.ExecuteReader()
                While reader.Read()
                    lista.Add(New ProyectoRe With {
                        .Id = CInt(reader("Id")),
                        .Nombre = reader("Nombre").ToString(),
                        .Descripcion = reader("Descripcion").ToString(),
                        .FechaInicio = CDate(reader("FechaInicio")),
                        .FechaFin = CDate(reader("FechaFin")),
                        .DocumentoRuta = reader("DocumentoRuta").ToString(),
                        .EspecieId = CInt(reader("EspecieId")),
                        .ComunidadId = CInt(reader("ComunidadId")),
                        .FechaCreacion = CDate(reader("FechaCreacion")),
                        .FechaActualizacion = CDate(reader("FechaActualizacion"))
                    })
                End While
            End Using
        End Using
        Return lista
    End Function

    Public Shared Sub Insertar(proyecto As ProyectoRe)
        Dim query As String = "INSERT INTO ProyectoReforestacion (Nombre, Descripcion, FechaInicio, FechaFin, DocumentoRuta, EspecieId, ComunidadId, FechaCreacion, FechaActualizacion) VALUES (@Nombre, @Descripcion, @FechaInicio, @FechaFin, @DocumentoRuta, @EspecieId, @ComunidadId, GETDATE(), GETDATE())"
        Using con As New SqlConnection(Conexion.Cadena)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Nombre", proyecto.Nombre)
                cmd.Parameters.AddWithValue("@Descripcion", proyecto.Descripcion)
                cmd.Parameters.AddWithValue("@FechaInicio", proyecto.FechaInicio)
                cmd.Parameters.AddWithValue("@FechaFin", proyecto.FechaFin)
                cmd.Parameters.AddWithValue("@DocumentoRuta", proyecto.DocumentoRuta)
                cmd.Parameters.AddWithValue("@EspecieId", proyecto.EspecieId)
                cmd.Parameters.AddWithValue("@ComunidadId", proyecto.ComunidadId)
                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' También puedo hacerte Actualizar() y Eliminar() si me confirmas.
End Class
