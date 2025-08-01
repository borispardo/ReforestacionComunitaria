<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="NuevoProyecto.aspx.vb" Inherits="ReforestacionComunitaria.NuevoProyecto" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Nuevo Proyecto de Reforestación</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <h2 class="text-center mb-4">Registrar Nuevo Proyecto de Reforestación</h2>

            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre del Proyecto</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" />
            </div>

            <div class="mb-3">
                <label for="ddlComunidad" class="form-label">Comunidad</label>
                <asp:DropDownList ID="ddlComunidad" runat="server" CssClass="form-select" />
            </div>

            <div class="mb-3">
                <label for="ddlEspecie" class="form-label">Especie</label>
                <asp:DropDownList ID="ddlEspecie" runat="server" CssClass="form-select" />
            </div>

            <div class="mb-3">
                <label for="txtFechaInicio" class="form-label">Fecha de Inicio</label>
                <asp:TextBox ID="txtFechaInicio" runat="server" CssClass="form-control" TextMode="Date" />
            </div>

            <div class="mb-3">
                <label for="txtFechaFin" class="form-label">Fecha de Fin</label>
                <asp:TextBox ID="txtFechaFin" runat="server" CssClass="form-control" TextMode="Date" />
            </div>

            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripción</label>
                <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="4" />
            </div>

            <div class="mb-3">
                <label for="fuArchivo" class="form-label">Archivo del Proyecto</label>
                <asp:FileUpload ID="fuArchivo" runat="server" CssClass="form-control" />
            </div>

            <asp:Button ID="btnGuardar" runat="server" Text="Guardar Proyecto" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
        </div>
    </form>
</body>
</html>
