<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Proyecto.aspx.vb" Inherits="ReforestacionComunitaria.Proyecto" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registrar Proyecto de Reforestación</title>

    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Bootstrap Select CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap-select@1.14.0-beta3/dist/css/bootstrap-select.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-4">
            <div class="card shadow">
                <div class="card-header">
                    <h3 class="mb-0">Registrar Proyecto de Reforestación</h3>
                </div>
                <div class="card-body">

                    <div class="form-group">
                        <label for="txtNombre">Nombre del Proyecto</label>
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" required="true" />
                    </div>

                    <div class="form-group">
                        <label for="ddlComunidad">Comunidad Participante</label>
                        <asp:DropDownList ID="ddlComunidad" runat="server" CssClass="form-control selectpicker" data-live-search="true" AppendDataBoundItems="true">
                            <asp:ListItem Text="Seleccione una comunidad" Value="" />
                        </asp:DropDownList>
                    </div>

                    <div class="form-group">
                        <label for="ddlEspecie">Especie a Reforestar</label>
                        <asp:DropDownList ID="ddlEspecie" runat="server" CssClass="form-control selectpicker" data-live-search="true" AppendDataBoundItems="true">
                            <asp:ListItem Text="Seleccione una especie" Value="" />
                        </asp:DropDownList>
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
                        <label for="fuArchivo">Archivo PDF del Proyecto</label>
                        <asp:FileUpload ID="fuArchivo" runat="server" CssClass="form-control-file" />
                    </div>

                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar Proyecto" CssClass="btn btn-success btn-block" OnClick="btnGuardar_Click" />

                </div>
            </div>
        </div>
    </form>

    <!-- Scripts -->
    <script src="https://code.jquery.com/jquery-3.7.0.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap-select@1.14.0-beta3/dist/js/bootstrap-select.min.js"></script>
</body>
</html>
