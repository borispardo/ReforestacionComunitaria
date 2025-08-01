<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="EditarProyecto.aspx.vb" Inherits="ReforestacionComunitaria.EditarProyecto" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Editar Proyecto</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap-select@1.14.0-beta3/dist/css/bootstrap-select.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="container mt-4">
        <div class="card">
            <div class="card-header">
                <h3 class="mb-0">Editar Proyecto de Reforestación</h3>
            </div>
            <div class="card-body">

                <asp:HiddenField ID="hfProyectoId" runat="server" />

                <div class="form-group">
                    <label for="txtNombre">Nombre del Proyecto</label>
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" required />
                </div>

                <div class="form-group">
                    <label for="ddlComunidad">Comunidad Participante</label>
                    <asp:DropDownList ID="ddlComunidad" runat="server" CssClass="form-control selectpicker" data-live-search="true" />
                </div>

                <div class="form-group">
                    <label for="ddlEspecie">Especie a Reforestar</label>
                    <asp:DropDownList ID="ddlEspecie" runat="server" CssClass="form-control selectpicker" data-live-search="true" />
                </div>

                <div class="form-group">
                    <label for="txtFechaInicio">Fecha Inicio</label>
                    <asp:TextBox ID="txtFechaInicio" runat="server" CssClass="form-control" TextMode="Date" />
                </div>

                <div class="form-group">
                    <label for="txtFechaFin">Fecha Fin</label>
                    <asp:TextBox ID="txtFechaFin" runat="server" CssClass="form-control" TextMode="Date" />
                </div>

                <div class="form-group">
                    <label for="txtDescripcion">Descripción</label>
                    <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="3" />
                </div>

                <div class="form-group">
                    <label for="fuArchivo">Archivo PDF del Proyecto (opcional)</label>
                    <asp:FileUpload ID="fuArchivo" runat="server" CssClass="form-control-file" />
                </div>

                <asp:Button ID="btnGuardar" runat="server" Text="Actualizar Proyecto" CssClass="btn btn-primary btn-block" OnClick="btnGuardar_Click" />
            </div>
        </div>
    </form>

    <script src="https://code.jquery.com/jquery-3.7.0.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap-select@1.14.0-beta3/dist/js/bootstrap-select.min.js"></script>
</body>
</html>
