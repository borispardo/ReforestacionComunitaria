
Public Class NuevaEspecie
    Inherits System.Web.UI.Page

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs)
        Try
            Dim nuevaEspecie As New EspecieRe With {
                .Nombre = txtNombreComun.Text.Trim(),
                .NombreCientifico = txtNombreCientifico.Text.Trim(),
                .Familia = txtFamilia.Text.Trim()
            }

            EspecieDAL.Insertar(nuevaEspecie)

            LimpiarFormulario()
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "success", "Swal.fire('Éxito', 'Especie registrada correctamente', 'success');", True)

        Catch ex As Exception
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "error", $"Swal.fire('Error', '{ex.Message}', 'error');", True)
        End Try
    End Sub

    Private Sub LimpiarFormulario()
        txtNombreComun.Text = ""
        txtNombreCientifico.Text = ""
        txtFamilia.Text = ""
    End Sub
End Class
