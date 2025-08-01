Imports System.Data.SqlClient

Public Class ProyectoDAL
    Public Shared Function ObtenerPorId(id As Integer) As ProyectoRe
        Dim query As String = "SELECT * FROM ProyectoReforestacion WHERE Id = @Id"
        Using con As New SqlConnection(Conexion.Cadena)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Id", id)
                con.Open()
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Return New ProyectoRe With {
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
                    }
                    Else
                        Return Nothing
                    End If
                End Using
            End Using
        End Using
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

    Public Shared Sub Eliminar(id As Integer)
        Dim query As String = "DELETE FROM ProyectoReforestacion WHERE Id = @Id"
        Using con As New SqlConnection(Conexion.Cadena)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Id", id)
                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Shared Sub Actualizar(proyecto As ProyectoRe)
        Dim query As String = "UPDATE ProyectoReforestacion SET " &
                              "Nombre = @Nombre, " &
                              "Descripcion = @Descripcion, " &
                              "FechaInicio = @FechaInicio, " &
                              "FechaFin = @FechaFin, " &
                              "DocumentoRuta = @DocumentoRuta, " &
                              "EspecieId = @EspecieId, " &
                              "ComunidadId = @ComunidadId, " &
                              "FechaActualizacion = GETDATE() " &
                              "WHERE Id = @Id"
        Using con As New SqlConnection(Conexion.Cadena)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Id", proyecto.Id)
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
End Class
