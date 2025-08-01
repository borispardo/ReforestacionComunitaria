
Partial Class NuevoProyecto
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarComunidades()
            CargarEspecies()
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
            If ddlComunidad.SelectedIndex = 0 Or ddlEspecie.SelectedIndex = 0 Then
                ScriptManager.RegisterStartupScript(Me, Me.GetType(), "warning", "Swal.fire('Atención','Debe seleccionar una comunidad y especie','warning');", True)
                Return
            End If

            Dim nuevoProyecto As New ProyectoRe With {
                .Nombre = txtNombre.Text.Trim(),
                .ComunidadId = Integer.Parse(ddlComunidad.SelectedValue),
                .EspecieId = Integer.Parse(ddlEspecie.SelectedValue),
                .FechaInicio = DateTime.Parse(txtFechaInicio.Text),
                .FechaFin = DateTime.Parse(txtFechaFin.Text),
                .Descripcion = txtDescripcion.Text.Trim(),
                .DocumentoRuta = GuardarArchivo()
            }

            ProyectoDAL.Insertar(nuevoProyecto)

            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "success", "Swal.fire('Éxito','Proyecto guardado correctamente','success');", True)

            txtNombre.Text = ""
            txtFechaInicio.Text = ""
            txtFechaFin.Text = ""
            txtDescripcion.Text = ""
            ddlComunidad.SelectedIndex = 0
            ddlEspecie.SelectedIndex = 0

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
