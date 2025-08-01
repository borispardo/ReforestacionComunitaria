<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="EliminarComunidad.aspx.vb" Inherits="ReforestacionComunitaria.EliminarComunidad" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Eliminar Comunidad</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>¿Estás seguro de que deseas eliminar esta comunidad?</h2>

        <asp:Label ID="lblNombre" runat="server" Font-Bold="True"></asp:Label>
        <br /><br />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" PostBackUrl="ListaComunidad.aspx" />
    </form>
</body>
</html>
