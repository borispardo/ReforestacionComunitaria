Imports System.Data.SqlClient

Public Class EspecieDAL

    Public Shared Function ObtenerTodas() As List(Of EspecieRe)
        Dim lista As New List(Of EspecieRe)
        Dim conStr As String = ConfigurationManager.ConnectionStrings("ConexionCatalogo").ConnectionString

        Using con As New SqlConnection(conStr)
            Dim cmd As New SqlCommand("SELECT * FROM Especie", con)
            con.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim especie As New EspecieRe()
                especie.Id = Convert.ToInt32(reader("Id"))
                especie.Nombre = reader("Nombre").ToString()
                especie.Familia = reader("Familia").ToString()
                ' Agrega más campos si los tienes
                lista.Add(especie)
            End While
        End Using

        Return lista
    End Function

    Public Shared Sub Insertar(especie As EspecieRe)
        Dim conStr As String = ConfigurationManager.ConnectionStrings("ConexionCatalogo").ConnectionString

        Using con As New SqlConnection(conStr)
            Dim query As String = "INSERT INTO Especie (Nombre, Familia) VALUES (@Nombre, @Familia)"
            Dim cmd As New SqlCommand(query, con)

            cmd.Parameters.AddWithValue("@Nombre", especie.Nombre)
            cmd.Parameters.AddWithValue("@Familia", especie.Familia)

            con.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Shared Sub Actualizar(especie As EspecieRe)
        Dim conStr As String = ConfigurationManager.ConnectionStrings("ConexionCatalogo").ConnectionString

        Using con As New SqlConnection(conStr)
            Dim query As String = "UPDATE Especie SET Nombre=@Nombre, Familia=@Familia WHERE Id=@Id"
            Dim cmd As New SqlCommand(query, con)

            cmd.Parameters.AddWithValue("@Id", especie.Id)
            cmd.Parameters.AddWithValue("@Nombre", especie.Nombre)
            cmd.Parameters.AddWithValue("@Familia", especie.Familia)

            con.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Shared Sub Eliminar(id As Integer)
        Dim conStr As String = ConfigurationManager.ConnectionStrings("ConexionCatalogo").ConnectionString

        Using con As New SqlConnection(conStr)
            Dim query As String = "DELETE FROM Especie WHERE Id=@Id"
            Dim cmd As New SqlCommand(query, con)

            cmd.Parameters.AddWithValue("@Id", id)

            con.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Shared Function ObtenerNombrePorId(id As Integer) As String
        Dim query As String = "SELECT Nombre FROM Especie WHERE Id = @Id"
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
