<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Administrador.Master" AutoEventWireup="true"
    CodeBehind="AdministrarClientes.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.admin.AdministrarClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headAdmin" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>
        Clientes</h2>
    <table class="table">
        <tr>
            <th>Nif</th>
            <th>Nombre</th>
            <th>Apellidos</th>
            <th>Username</th>
        </tr>
        <% var clientes = ObtenerClientes(); %>
        <% foreach (var c in clientes) %>
        <% { %>
        <tr>
            <td><%= c.NIF %></td>
            <td><%= c.Nombre %></td>
            <td><%= c.Apellidos %></td>
            <td><%= c.Username %></td>
        </tr>
        <% } %>
    </table>
</asp:Content>
