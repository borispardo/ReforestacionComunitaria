
Public Class EditarEspecie
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim idStr As String = Request.QueryString("id")
            If Not String.IsNullOrEmpty(idStr) AndAlso IsNumeric(idStr) Then
                Dim id As Integer = Convert.ToInt32(idStr)
                CargarEspecie(id)
            Else
                Response.Redirect("Especie.aspx")
            End If
        End If
    End Sub

    Private Sub CargarEspecie(id As Integer)
        Try
            Dim especie As EspecieRe = EspecieDAL.ObtenerPorId(id)
            If especie IsNot Nothing Then
                hfIdEspecie.Value = especie.Id.ToString()
                txtNombreComun.Text = especie.Nombre
                txtNombreCientifico.Text = especie.NombreCientifico
                txtFamilia.Text = especie.Familia
            Else
                ScriptManager.RegisterStartupScript(Me, Me.GetType(), "error", "Swal.fire('Error', 'Especie no encontrada', 'error');", True)
            End If
        Catch ex As Exception
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "error", $"Swal.fire('Error', '{ex.Message}', 'error');", True)
        End Try
    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs)
        Try
            Dim especieActualizada As New EspecieRe With {
                .Id = Convert.ToInt32(hfIdEspecie.Value),
                .Nombre = txtNombreComun.Text.Trim(),
                .NombreCientifico = txtNombreCientifico.Text.Trim(),
                .Familia = txtFamilia.Text.Trim()
            }

            EspecieDAL.Actualizar(especieActualizada)

            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "success", "Swal.fire('Actualizado', 'La especie fue actualizada correctamente', 'success').then(() => { window.location = 'Especie.aspx'; });", True)

        Catch ex As Exception
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "error", $"Swal.fire('Error', '{ex.Message}', 'error');", True)
        End Try
    End Sub
End Class
