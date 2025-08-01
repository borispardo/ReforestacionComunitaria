
Partial Class EditarProyecto
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarComunidades()
            CargarEspecies()

            Dim id = Request.QueryString("id")
            If Not String.IsNullOrEmpty(id) Then
                Dim proyecto = ProyectoDAL.ObtenerPorId(Integer.Parse(id))
                If proyecto IsNot Nothing Then
                    hfProyectoId.Value = proyecto.Id.ToString()
                    txtNombre.Text = proyecto.Nombre
                    ddlComunidad.SelectedValue = proyecto.ComunidadId.ToString()
                    ddlEspecie.SelectedValue = proyecto.EspecieId.ToString()
                    txtFechaInicio.Text = proyecto.FechaInicio.ToString("yyyy-MM-dd")
                    txtFechaFin.Text = proyecto.FechaFin.ToString("yyyy-MM-dd")
                    txtDescripcion.Text = proyecto.Descripcion
                End If
            End If
        End If
    End Sub

    Private Sub CargarComunidades()
        ddlComunidad.DataSource = ComunidadDAL.ObtenerTodas()
        ddlComunidad.DataTextField = "Nombre"
        ddlComunidad.DataValueField = "Id"
        ddlComunidad.DataBind()
        ddlComunidad.Items.Insert(0, New ListItem("Seleccione una comunidad", ""))
    End Sub

    Private Sub CargarEspecies()
        ddlEspecie.DataSource = EspecieDAL.ObtenerTodas()
        ddlEspecie.DataTextField = "NombreComun"
        ddlEspecie.DataValueField = "Id"
        ddlEspecie.DataBind()
        ddlEspecie.Items.Insert(0, New ListItem("Seleccione una especie", ""))
    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs)
        Try
            Dim id = Integer.Parse(hfProyectoId.Value)

            Dim proyectoEditado As New ProyectoRe With {
                .Id = id,
                .Nombre = txtNombre.Text.Trim(),
                .ComunidadId = Integer.Parse(ddlComunidad.SelectedValue),
                .EspecieId = Integer.Parse(ddlEspecie.SelectedValue),
                .FechaInicio = DateTime.Parse(txtFechaInicio.Text),
                .FechaFin = DateTime.Parse(txtFechaFin.Text),
                .Descripcion = txtDescripcion.Text.Trim()
            }

            If fuArchivo.HasFile Then
                proyectoEditado.DocumentoRuta = GuardarArchivo()
            End If

            ProyectoDAL.Actualizar(proyectoEditado)

            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "success", "Swal.fire('Éxito','Proyecto actualizado correctamente','success');", True)

        Catch ex As Exception
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "error", $"Swal.fire('Error','{ex.Message}','error');", True)
        End Try
    End Sub

    Private Function GuardarArchivo() As String
        If fuArchivo.HasFile Then
            Dim nombreArchivo = System.IO.Path.GetFileName(fuArchivo.FileName)
            Dim ruta = Server.MapPath("~/Archivos/")
            If Not IO.Directory.Exists(ruta) Then
                IO.Directory.CreateDirectory(ruta)
            End If
            Dim rutaCompleta = IO.Path.Combine(ruta, nombreArchivo)
            fuArchivo.SaveAs(rutaCompleta)
            Return "Archivos/" & nombreArchivo
        Else
            Return String.Empty
        End If
    End Function
End Class
