<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Administrador.Master" AutoEventWireup="true"
    CodeBehind="AdministrarClientes.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.admin.AdministrarClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headAdmin" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
    <div class="container">
        <h2>
            Clientes</h2>
        <table class="table table-bordered table-hover">
            <tr>
                <th>
                    Nif
                </th>
                <th>
                    Nombre
                </th>
                <th>
                    Apellidos
                </th>
                <th>
                    Username
                </th>
                <th>
                    Seguimiento
                </th>
            </tr>
            <% var clientes = ObtenerClientes(); %>
            <% foreach (var c in clientes) %>
            <% { %>
            <tr>
                <td>
                    <%= c.NIF %>
                </td>
                <td>
                    <%= c.Nombre %>
                </td>
                <td>
                    <%= c.Apellidos %>
                </td>
                <td>
                    <%= c.Username %>
                </td>
                <td>
                    <a href="Seguimiento.aspx?id=<%: c.NIF %>">Seguimiento</a>
                </td>
            </tr>
            <% } %>
        </table>
    </div>
    </form>
</asp:Content>
