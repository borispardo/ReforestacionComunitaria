
Partial Class ComunidadPAR
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarComunidades()
        End If
    End Sub

    Private Sub CargarComunidades()
        Dim lista As List(Of ComunidadPa) = ComunidadDAL.ObtenerTodas()
        gvComunidades.DataSource = lista
        gvComunidades.DataBind()
    End Sub
End Class
