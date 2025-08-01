<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Especie.aspx.vb" Inherits="ReforestacionComunitaria.EspecieWeb" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Nueva Especie</title>
    <meta charset="utf-8" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css" />
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
</head>
<body>
    <form id="form1" runat="server" class="container mt-5">
        <div class="card shadow">
            <div class="card-header bg-success text-white">
                <h4 class="mb-0">Registro de Especie</h4>
            </div>
            <div class="card-body">
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

                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success btn-block" OnClick="btnGuardar_Click" />
            </div>
        </div>

        <div class="mt-4">
            <asp:GridView ID="gvEspecies" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-striped"
                OnRowEditing="gvEspecies_RowEditing" OnRowUpdating="gvEspecies_RowUpdating" OnRowCancelingEdit="gvEspecies_RowCancelingEdit"
                OnRowDeleting="gvEspecies_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="True" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre Común" />
                    <asp:BoundField DataField="Familia" HeaderText="Familia" />
                    <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>

    <script src="https://code.jquery.com/jquery-3.7.0.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
