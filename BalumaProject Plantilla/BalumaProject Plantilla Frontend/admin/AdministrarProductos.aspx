<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Administrador.Master" AutoEventWireup="true" CodeBehind="AdministrarProductos.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.admin.AdministrarProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headAdmin" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
    <table class="table table-bordered table-hover">
        <tr>
            <th>ID</th>
            <th>Nombre</th>
            <th>Precio</th>
            <th>Cantidad</th>
            <th>Editar</th>
        </tr>
        <% var productos = ObtenerProductos(); %>
        <% foreach (var p in productos) %>
        <% { %>
        <tr>
            <td><%= p.IdProducto %></td>
            <td><%= p.Nombre %></td>
            <td><%= p.Precio %></td>
            <td><%= p.Cantidad %></td>
            <td><a href="EditarProducto.aspx?id=<%: p.IdProducto %>&nombre=<%: p.Nombre %>">editar</a></td>
        </tr>
        <% } %>
    </table>
    </div>
    
</asp:Content>
