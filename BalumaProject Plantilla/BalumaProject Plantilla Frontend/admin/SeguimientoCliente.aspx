<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Administrador.Master" AutoEventWireup="true" CodeBehind="SeguimientoCliente.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.admin.SeguimientoCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headAdmin" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table class="table">
            <tr>
                <th>ID</th>
                <th>Tipo Pago</th>
                <th>Estado</th>
            </tr>
            <% foreach (var p in ObtenerPedidos()) %>
            <% { %>
            <tr>
                <td><%= p.IdPedido %></td>
                <td><%= p.TipoPago %></td>
                <td><%= p.Estado %></td>
            </tr>
            <% } %>
        </table>
    </div>
</asp:Content>
