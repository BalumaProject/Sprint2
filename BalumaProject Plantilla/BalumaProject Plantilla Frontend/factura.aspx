<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="factura.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.factura" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form id="Form1"  runat = "server">
<div class="main_bg">
<div class="wrap">
<div class="main">
    <div class="factura">
           <h3>VISTA PREVIA</h3>
           <div class="registration_form">
                <iframe width="100%" height="450" src="sesion5_problemas.pdf"></iframe>
                <div>
					<asp:Button ID="Descargar" text="Descargar"  runat="server"/>
                    <asp:Button ID="Continuar" text="Continuar compra"  runat = "server" />
				</div>
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