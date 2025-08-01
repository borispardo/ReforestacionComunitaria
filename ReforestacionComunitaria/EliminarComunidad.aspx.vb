Imports ReforestacionComunitaria.ReforestacionComunitaria.Modelos


Public Class EliminarComunidad
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim idStr As String = Request.QueryString("id")
            If Not String.IsNullOrEmpty(idStr) AndAlso IsNumeric(idStr) Then
                Dim id As Integer = CInt(idStr)
                Dim comunidad As ComunidadPa = ComunidadDAL.ObtenerPorId(id)

                If comunidad IsNot Nothing Then
                    lblNombre.Text = "Nombre: " & comunidad.Nombre
                    ViewState("ComunidadId") = comunidad.Id
                Else
                    Response.Redirect("ListaComunidad.aspx")
                End If
            Else
                Response.Redirect("ListaComunidad.aspx")
            End If
        End If
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs)
        Dim id As Integer = CInt(ViewState("ComunidadId"))
        ComunidadDAL.Eliminar(id)
        Response.Redirect("ListaComunidad.aspx")
    End Sub
End Class
