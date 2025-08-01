<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="EditarComunidad.aspx.vb" Inherits="ReforestacionComunitaria.EditarComunidad" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Editar Comunidad</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Editar Comunidad</h2>

        <asp:HiddenField ID="hfId" runat="server" />

        <asp:Label Text="Nombre:" AssociatedControlID="txtNombre" runat="server" />
        <asp:TextBox ID="txtNombre" runat="server" /><br />

        <asp:Label Text="Latitud:" AssociatedControlID="txtLatitud" runat="server" />
        <asp:TextBox ID="txtLatitud" runat="server" /><br />

        <asp:Label Text="Longitud:" AssociatedControlID="txtLongitud" runat="server" />
        <asp:TextBox ID="txtLongitud" runat="server" /><br />

        <asp:Label Text="Descripción:" AssociatedControlID="txtDescripcion" runat="server" />
        <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" /><br />

        <asp:Button ID="btnActualizar" Text="Actualizar" runat="server" OnClick="btnActualizar_Click" />
        <asp:HyperLink NavigateUrl="ListaComunidad.aspx" Text="Cancelar" runat="server" />
    </form>
</body>
</html>
