<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="Catalogo.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.Catalogo" %>

<%@ MasterType VirtualPath="~/Site1.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form id="form" runat="server">
    <div class="main_bg">
        <div class="wrap">
            <div class="main">
                
                <div class="panel-buscar">
                    <div class="top-buscar">
                        <asp:Label Text="Filtro de búsqueda" runat="server" />
                    </div>
                    <asp:Label Text="Por Categoria" runat="server" CssClass="etiqueta-buscar" />
                    <asp:DropDownList ID="lista" runat="server" CssClass="lista-categoria">
                        <asp:ListItem Text="Todos"></asp:ListItem>
                        <asp:ListItem Text="Latina"></asp:ListItem>
                        <asp:ListItem Text="De cuchillo"></asp:ListItem>
                        <asp:ListItem Text="Cuadra"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label Text="Por Precio" runat="server" CssClass="etiqueta-buscar" />
                    <asp:TextBox ID="precio" runat="server" CssClass="lista-categoria"></asp:TextBox>
                    <div class="registration_form">
                        <div class="boton-buscar">
                            <asp:Button OnClick="BuscarProductos" Text="Buscar" runat="server" />
                        </div>
                    </div>
                </div>
            </div>
            <% var contador = 0; %>
            <div class="grids_of_3">
                <% var prods = ObtenerProductos(); %>
                <% foreach (var p in prods) %>
                <% { %>
                <% if (contador == 3) %>
                <%{ %>
                <div class="clear">
                </div>
                <div class="grids_of_3">
                    <% contador = 0; %>
                    <%} %>
                    <div class="grid1_of_3">
                        <a href="#">
                            <img src="Content/images/bavaria.jpg" alt="Imagen del producto" />
                        </a>
                        <%= p.Nombre %>
                        <span class="price"><%= p.Precio %> €</span> 
                        <asp:Button Text="Añadir" OnClick="anyadeCarrito" runat="server" />
                    </div>
                    <% contador++; %>
                    <% } %>
                </div>
            </div>
            <div class="clear" />
    </div>
    </form>
    <!-- start footer -->
    <div class="footer_bg">
        <div class="wrap">
            <div class="footer">
                <div class="f_nav1">
                    <ul>
                        <li><a href="~/indice.aspx" runat="server">Inicio/</a></li>
                        <li><a href="#">Términos y condiciones /</a></li>
                        <li><a href="#">Contáctanos</a></li>
                    </ul>
                </div>
                <div class="clear">
                </div>
            </div>
        </div>
    </div>
</asp:Content>
