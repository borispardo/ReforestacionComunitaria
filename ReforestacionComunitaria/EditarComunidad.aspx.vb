
Imports ReforestacionComunitaria.ReforestacionComunitaria.Modelos

Partial Class EditarComunidad
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim id As Integer
            If Integer.TryParse(Request.QueryString("id"), id) Then
                CargarDatos(id)
            Else
                Response.Redirect("ListaComunidad.aspx")
            End If
        End If
    End Sub

    Private Sub CargarDatos(id As Integer)
        Dim comunidad As ComunidadPa = ComunidadDAL.ObtenerTodas().FirstOrDefault(Function(c) c.Id = id)
        If comunidad IsNot Nothing Then
            hfId.Value = comunidad.Id.ToString()
            txtNombre.Text = comunidad.Nombre
            txtLatitud.Text = comunidad.Latitud.ToString()
            txtLongitud.Text = comunidad.Longitud.ToString()
            txtDescripcion.Text = comunidad.Descripcion
        Else
            Response.Redirect("ListaComunidad.aspx")
        End If
    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs)
        Dim comunidadEditada As New ComunidadPa With {
            .ID = Convert.ToInt32(hfId.Value),
            .Nombre = txtNombre.Text,
            .Latitud = Convert.ToDecimal(txtLatitud.Text),
            .Longitud = Convert.ToDecimal(txtLongitud.Text),
            .Descripcion = txtDescripcion.Text
        }

        ComunidadDAL.Actualizar(comunidadEditada)
        Response.Redirect("ListaComunidad.aspx")
    End Sub
End Class
