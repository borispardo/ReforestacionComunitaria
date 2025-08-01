
Public Class EspecieWeb
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarEspecies()
        End If
    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs)
        Try
            Dim nuevaEspecie As New EspecieRe With {
                .Nombre = txtNombreComun.Text.Trim(),
                .NombreCientifico = txtNombreCientifico.Text.Trim(),
                .Familia = txtFamilia.Text.Trim()
            }

            EspecieDAL.Insertar(nuevaEspecie)
            LimpiarFormulario()
            CargarEspecies()

            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "success", "Swal.fire('Éxito', 'Especie registrada correctamente', 'success');", True)
        Catch ex As Exception
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "error", $"Swal.fire('Error', '{ex.Message}', 'error');", True)
        End Try
    End Sub

    Private Sub CargarEspecies()
        gvEspecies.DataSource = EspecieDAL.ObtenerTodas()
        gvEspecies.DataBind()
    End Sub

    Private Sub LimpiarFormulario()
        txtNombreComun.Text = ""
        txtNombreCientifico.Text = ""
        txtFamilia.Text = ""
    End Sub

    Protected Sub gvEspecies_RowEditing(sender As Object, e As GridViewEditEventArgs)
        gvEspecies.EditIndex = e.NewEditIndex
        CargarEspecies()
    End Sub

    Protected Sub gvEspecies_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs)
        gvEspecies.EditIndex = -1
        CargarEspecies()
    End Sub

    Protected Sub gvEspecies_RowUpdating(sender As Object, e As GridViewUpdateEventArgs)
        Try
            Dim id As Integer = Convert.ToInt32(gvEspecies.DataKeys(e.RowIndex).Value)
            Dim row As GridViewRow = gvEspecies.Rows(e.RowIndex)

            Dim nombreComun As String = CType(row.Cells(1).Controls(0), TextBox).Text.Trim()
            Dim familia As String = CType(row.Cells(2).Controls(0), TextBox).Text.Trim()
            Dim NombreCientifico As String = CType(row.Cells(3).Controls(0), TextBox).Text.Trim()

            Dim especieActualizada As New EspecieRe With {
                .Id = id,
                .Nombre = nombreComun,
                .NombreCientifico = NombreCientifico,
                .Familia = familia
            }

            EspecieDAL.Actualizar(especieActualizada)
            gvEspecies.EditIndex = -1
            CargarEspecies()

            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "success", "Swal.fire('Actualizado', 'Especie actualizada correctamente', 'success');", True)
        Catch ex As Exception
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "error", $"Swal.fire('Error', '{ex.Message}', 'error');", True)
        End Try
    End Sub

    Protected Sub gvEspecies_RowDeleting(sender As Object, e As GridViewDeleteEventArgs)
        Try
            Dim id As Integer = Convert.ToInt32(gvEspecies.DataKeys(e.RowIndex).Value)
            EspecieDAL.Eliminar(id)
            CargarEspecies()

            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "success", "Swal.fire('Eliminado', 'Especie eliminada correctamente', 'success');", True)
        Catch ex As Exception
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "error", $"Swal.fire('Error', '{ex.Message}', 'error');", True)
        End Try
    End Sub
End Class
