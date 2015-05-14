<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Administrador.Master" AutoEventWireup="true" CodeBehind="AdministrarProductos.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.admin.AdministrarProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headAdmin" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="table">
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
            <td><a href="#">editar</a></td>
        </tr>
        <% } %>
    </table>
</asp:Content>
