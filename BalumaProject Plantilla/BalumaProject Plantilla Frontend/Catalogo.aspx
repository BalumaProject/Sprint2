<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.Catalogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="main_bg">
<div class="wrap">
<div class="main">

<form runat="server">

	<div class="panel-buscar">
    
    <div class="top-buscar">
    <asp:Label Text="Filtro de búsqueda" runat="server"/>
    </div>
    <asp:Label Text="Por Categoria" runat="server" CssClass="etiqueta-buscar"/>
    <asp:DropDownList id = "lista" runat="server" CssClass="lista-categoria">
    <asp:ListItem Text="Todos"></asp:ListItem>
    <asp:ListItem   Text="Latina"></asp:ListItem>
    <asp:ListItem  Text="De cuchillo"></asp:ListItem>
    <asp:ListItem  Text="Cuadra"></asp:ListItem>
    
    </asp:DropDownList>
    <asp:Label Text="Por Precio" runat="server" CssClass="etiqueta-buscar"/>
    <asp:TextBox id = "precio" runat="server" CssClass="lista-categoria"></asp:TextBox>
    
    <div class="registration_form">
    <div class="boton-buscar">
    <asp:Button Onclick = "buscar_productos" Text="Buscar" runat="server"/>
    </div>
    </div>
    </div>
    

</div>

<%=content%> <!--contenido autogenerado en  Catalogo.aspx.cs para items dinámicos-->
	
</div>
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
	
	<div class="clear"></div>
</div>
</div>
</div>
</asp:Content>
