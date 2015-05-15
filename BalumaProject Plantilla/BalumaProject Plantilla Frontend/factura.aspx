<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="factura.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.factura" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form id="Form1"  runat = "server">
<div class="main_bg">
<div class="wrap">
<div class="main">
        <table class="table">
            <tr>
               <th>ID</th>
               <th>Nombre</th>
               <th>Precio</th>
               <th>Cantidad</th>
               <th>Eliminar</th>
            </tr>
            <% var productos = ObtenerProductos(); %>
            <% foreach (var p in productos) %>
            <% { %>
            <tr>
                    <td><%= p.IdProducto %></td>
                    <td><%= p.Nombre %></td>
                    <td><%= p.Precio %></td>
                    <td><%= p.Cantidad %></td>
                    <td><a href="EliminarProducto.aspx?id=<%: p.IdProducto %>">eliminar</a></td>
            </tr>
            <% } %>
        </table>
        <div class="registration_form">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem>VISA</asp:ListItem>
                    <asp:ListItem>Paypal</asp:ListItem>
                </asp:RadioButtonList>
                <div>
                    <asp:Button ID="Descargar" text="Descargar" OnClick = "generar_factura" runat = "server"/>
                    <asp:Button ID="Continuar" text="Continuar compra"  runat = "server" />
				</div>
           </div>
    <div class="clear"></div>
</div>
</div>
</div>
</form>
<!-- start footer -->
<div class="footer_bg">
<div class="wrap">
<div class="footer">

	<div class="f_nav1">
		<ul>
			<li><a id="A1" href="~/indice.aspx" runat="server">Inicio/</a></li>
			<li><a href="#">Términos y condiciones /</a></li>
			<li><a href="#">Contáctanos</a></li>
		</ul>
		</div>
	
	<div class="clear"></div>
</div>
</div>
</div>
</asp:Content>