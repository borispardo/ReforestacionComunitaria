
Public Class EliminarProyecto
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim id = Request.QueryString("id")
            If Not String.IsNullOrEmpty(id) Then
                Dim proyecto = ProyectoDAL.ObtenerPorId(Integer.Parse(id))
                If proyecto IsNot Nothing Then
                    hfProyectoId.Value = proyecto.Id.ToString()
                    lblNombre.Text = proyecto.Nombre
                    lblComunidad.Text = ComunidadDAL.ObtenerNombrePorId(proyecto.ComunidadId)
                    lblEspecie.Text = EspecieDAL.ObtenerNombrePorId(proyecto.EspecieId)
                Else
                    Response.Redirect("ListaProyectos.aspx")
                End If
            Else
                Response.Redirect("ListaProyectos.aspx")
            End If
        End If
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs)
        Dim id As Integer = Integer.Parse(hfProyectoId.Value)
        ProyectoDAL.Eliminar(id)
        Response.Redirect("ListaProyectos.aspx")
    End Sub
End Class
