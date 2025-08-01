<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="EliminarProyecto.aspx.vb" Inherits="ReforestacionComunitaria.EliminarProyecto" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Eliminar Proyecto</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="container mt-5">
        <div class="card">
            <div class="card-header bg-danger text-white">
                <h3>Eliminar Proyecto</h3>
            </div>
            <div class="card-body">
                <asp:HiddenField ID="hfProyectoId" runat="server" />
                <p>¿Estás seguro de que deseas eliminar el siguiente proyecto?</p>

                <div class="form-group">
                    <label>Nombre del Proyecto:</label>
                    <asp:Label ID="lblNombre" runat="server" CssClass="form-control" />
                </div>

                <div class="form-group">
                    <label>Comunidad:</label>
                    <asp:Label ID="lblComunidad" runat="server" CssClass="form-control" />
                </div>

                <div class="form-group">
                    <label>Especie:</label>
                    <asp:Label ID="lblEspecie" runat="server" CssClass="form-control" />
                </div>

                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click" />
                <a href="ListaProyectos.aspx" class="btn btn-secondary">Cancelar</a>
            </div>
        </div>
    </form>
</body>
</html>
