<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Administrador.Master" AutoEventWireup="true"
    CodeBehind="Seguimiento.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.admin.Seguimiento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headAdmin" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
     <h2>
        Clientes</h2>
    <table class="table">
        <tr>
            <th>Nif</th>
            <th>Nombre</th>
            <th>Apellidos</th>
            <th>Username</th>
            <th>Seguimiento</th>
        </tr>
        <% var clientes = ObtenerClientes(); %>
        <% foreach (var c in clientes) %>
        <% { %>
        <tr>
            <td><%= c.NIF %></td>
            <td><%= c.Nombre %></td>
            <td><%= c.Apellidos %></td>
            <td><%= c.Username %></td>
            <td><a href="SeguimientoCliente.aspx?id=<%: c.NIF %>">Seguimiento</a></td>
        </tr>
        <% } %>
    </table>
    </div>
   
</asp:Content>
