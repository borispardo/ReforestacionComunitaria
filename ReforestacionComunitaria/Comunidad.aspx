<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Comunidad.aspx.vb" Inherits="ReforestacionComunitaria.ComunidadPAR" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Lista de Comunidades</title>
    <link href="https://cdn.datatables.net/1.13.5/css/jquery.dataTables.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-4">
            <h2>Comunidades Participantes</h2>
            <asp:GridView ID="gvComunidades" runat="server" AutoGenerateColumns="False" CssClass="display">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="ID" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Latitud" HeaderText="Latitud" />
                    <asp:BoundField DataField="Longitud" HeaderText="Longitud" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                </Columns>
            </asp:GridView>
        </div>
    </form>

    <script src="https://code.jquery.com/jquery-3.7.0.min.js"></script>
    <script src="https://cdn.datatables.net/1.13.5/js/jquery.dataTables.min.js"></script>
    <script>
        $(document).ready(function () {
            $('.display').DataTable();
        });
    </script>
</body>
</html>
