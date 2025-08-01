
Public Class EliminarEspecie
    Inherits System.Web.UI.Page

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs)
        Dim id As Integer

        If Integer.TryParse(txtId.Text.Trim(), id) Then
            Try
                EspecieDAL.Eliminar(id)
                lblMensaje.Text = "Especie eliminada correctamente."
                lblMensaje.CssClass = "alert alert-success"
                lblMensaje.Visible = True

                ' Limpia textbox
                txtId.Text = ""

                ' Opcional: mostrar alerta con SweetAlert2
                ScriptManager.RegisterStartupScript(Me, Me.GetType(), "success", "Swal.fire('Eliminado', 'Especie eliminada correctamente', 'success');", True)
            Catch ex As Exception
                lblMensaje.Text = "Error al eliminar: " & ex.Message
                lblMensaje.CssClass = "alert alert-danger"
                lblMensaje.Visible = True
                ScriptManager.RegisterStartupScript(Me, Me.GetType(), "error", $"Swal.fire('Error','{ex.Message}','error');", True)
            End Try
        Else
            lblMensaje.Text = "Por favor, ingresa un ID válido."
            lblMensaje.CssClass = "alert alert-warning"
            lblMensaje.Visible = True
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "warning", "Swal.fire('Atención','Por favor, ingresa un ID válido','warning');", True)
        End If
    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs)
        ' Opcional: limpiar el formulario o redirigir
        txtId.Text = ""
        lblMensaje.Visible = False
    End Sub
End Class
