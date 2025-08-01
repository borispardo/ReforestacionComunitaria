
Partial Class NuevaComunidad
    Inherits System.Web.UI.Page

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs)
        Dim nuevaComunidad As New Comunidad With {
            .Nombre = txtNombre.Text,
            .Latitud = Convert.ToDecimal(txtLatitud.Text),
            .Longitud = Convert.ToDecimal(txtLongitud.Text),
            .Descripcion = txtDescripcion.Text
        }

        ComunidadDAL.Insertar(nuevaComunidad)
        Response.Redirect("Comunidad.aspx")
    End Sub
End Class
