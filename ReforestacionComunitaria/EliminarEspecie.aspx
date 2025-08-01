<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="EliminarEspecie.aspx.vb" Inherits="ReforestacionComunitaria.EliminarEspecie" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Eliminar Especie</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css" />
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
</head>
<body>
    <form id="form1" runat="server" class="container mt-5">
        <div class="card shadow">
            <div class="card-header bg-danger text-white">
                <h4 class="mb-0">Eliminar Especie</h4>
            </div>
            <div class="card-body">
                <asp:Label ID="lblMensaje" runat="server" CssClass="alert alert-warning" Visible="False"></asp:Label>

                <div class="form-group">
                    <asp:Label ID="lblId" runat="server" Text="ID de Especie:" AssociatedControlID="txtId" />
                    <asp:TextBox ID="txtId" runat="server" CssClass="form-control" />
                </div>
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger btn-block" OnClick="btnEliminar_Click" />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-secondary btn-block mt-2" OnClick="btnCancelar_Click" />
            </div>
        </div>
    </form>
</body>
</html>
