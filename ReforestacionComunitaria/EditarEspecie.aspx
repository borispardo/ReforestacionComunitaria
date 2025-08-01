<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="EditarEspecie.aspx.vb" Inherits="ReforestacionComunitaria.EditarEspecie" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Editar Especie</title>
    <meta charset="utf-8" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css" />
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
</head>
<body>
    <form id="form1" runat="server" class="container mt-5">
        <div class="card shadow">
            <div class="card-header bg-warning text-white">
                <h4 class="mb-0">Editar Especie</h4>
            </div>
            <div class="card-body">

                <asp:HiddenField ID="hfIdEspecie" runat="server" />

                <div class="form-group">
                    <label for="txtNombreComun">Nombre Común</label>
                    <asp:TextBox ID="txtNombreComun" runat="server" CssClass="form-control" required="true" />
                </div>

                <div class="form-group">
                    <label for="txtNombreCientifico">Nombre Científico</label>
                    <asp:TextBox ID="txtNombreCientifico" runat="server" CssClass="form-control" />
                </div>

                <div class="form-group">
                    <label for="txtFamilia">Familia</label>
                    <asp:TextBox ID="txtFamilia" runat="server" CssClass="form-control" />
                </div>

                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" CssClass="btn btn-warning btn-block" OnClick="btnActualizar_Click" />
                <asp:HyperLink ID="hlVolver" runat="server" NavigateUrl="~/Especie.aspx" CssClass="btn btn-secondary btn-block mt-2">Volver</asp:HyperLink>

            </div>
        </div>
    </form>

    <script src="https://code.jquery.com/jquery-3.7.0.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
