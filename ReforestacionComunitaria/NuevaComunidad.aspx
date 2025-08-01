<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="NuevaComunidad.aspx.vb" Inherits="ReforestacionComunitaria.NuevaComunidad" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Nueva Comunidad</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <h2>Registrar Nueva Comunidad</h2>

            <div>
                <asp:Label Text="Nombre:" AssociatedControlID="txtNombre" runat="server" />
                <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server" /><br />
            </div>

            <div>
                <asp:Label Text="Latitud:" AssociatedControlID="txtLatitud" runat="server" />
                <asp:TextBox ID="txtLatitud" CssClass="form-control" runat="server" /><br />
            </div>

            <div>
                <asp:Label Text="Longitud:" AssociatedControlID="txtLongitud" runat="server" />
                <asp:TextBox ID="txtLongitud" CssClass="form-control" runat="server" /><br />
            </div>

            <div>
                <asp:Label Text="Descripción:" AssociatedControlID="txtDescripcion" runat="server" />
                <asp:TextBox ID="txtDescripcion" CssClass="form-control" TextMode="MultiLine" Rows="4" runat="server" /><br />
            </div>

            <div>
                <asp:Button ID="btnGuardar" Text="Guardar" CssClass="btn btn-success" runat="server" OnClick="btnGuardar_Click" />
            </div>
        </div>
    </form>
</body>
</html>
