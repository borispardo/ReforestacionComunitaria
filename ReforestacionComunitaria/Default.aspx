<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="ReforestacionComunitaria.Default" MasterPageFile="~/Site.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Panel de Control - Reforestación Comunitaria
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="dashboard-title text-center mb-5">Panel de Control - Reforestación Comunitaria</h1>

    <div class="row">
        <div class="col-md-4 mb-4">
            <div class="card text-white bg-success h-100" style="cursor:pointer" onclick="location.href='Proyecto.aspx';">
                <div class="card-body d-flex flex-column justify-content-center align-items-center">
                    <h4 class="card-title">Proyectos</h4>
                    <p class="card-text">Gestiona los proyectos de reforestación.</p>
                    <i class="bi bi-tree-fill" style="font-size: 3rem;"></i>
                </div>
            </div>
        </div>

        <div class="col-md-4 mb-4">
            <div class="card text-white bg-primary h-100" style="cursor:pointer" onclick="location.href='Comunidad.aspx';">
                <div class="card-body d-flex flex-column justify-content-center align-items-center">
                    <h4 class="card-title">Comunidades</h4>
                    <p class="card-text">Administra las comunidades involucradas.</p>
                    <i class="bi bi-people-fill" style="font-size: 3rem;"></i>
                </div>
            </div>
        </div>

        <div class="col-md-4 mb-4">
            <div class="card text-white bg-info h-100" style="cursor:pointer" onclick="location.href='Especie.aspx';">
                <div class="card-body d-flex flex-column justify-content-center align-items-center">
                    <h4 class="card-title">Especies</h4>
                    <p class="card-text">Gestiona las especies de árboles.</p>
                    <i class="bi bi-leaf-fill" style="font-size: 3rem;"></i>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
