<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="contacto.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.contacto" %>
<%@ Register Assembly="GMaps" Namespace="Subgurim.Controles" TagPrefix="cc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form id="Form1"  runat = "server">
<div class="main_bg">
<div class="wrap">
<div class="main">

    <div class="login_left">
		<h3>visítanos</h3>
        <p>
        <span style='color:#ff7e00'>Baluma</span><br />
        Escuela Politécnica Superior <br />
        03690 San Vicente del Raspeig, España <br />
        Tel: +34 902 00 00 00 <br />Fax: +34 91 000 00 00<br />
        <br />Email: <a href='balumaproject@gmail.com' class='txtBKM'>
        balumaproject@gmail.com</a><br/>
        </p>
	<div class="registration">
	<div class="registration_left">
		 <div class="google-maps">
                <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3127.504787402501!2d-0.5120190000000128!3d38.383576!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0xd6236bb72bf619b%3A0x506e11c403138428!2sUniversidad+de+Alicante!5e0!3m2!1ses!2ses!4v1429553426294" width="600" height="450" frameborder="0" style="border:0"></iframe>
         </div>
	</div>
	</div>
	</div>

    <div class="login_left">
		<h3>Contacta con nosotros</h3>
		<div class="registration_left">
		
		 <div class="registration_form">
                
                <div>
					<label>
						<asp:TextBox ID = "nombre" type="text" tabindex="1" required="" text = "Nombre:" runat="server" />
					</label>
				</div>
                <div>
					<label>
						<asp:TextBox ID = "tema" type="text" tabindex="2" required="" text = "Tema:" runat="server" />
					</label>
				</div>
                <div>
					<label>
						<asp:TextBox ID = "email" type="text" tabindex="3" required="" text = "Email:" runat="server" />
					</label>
				</div>
				<div>
					<label>
						<asp:TextBox  ID = "mensaje" type="text" tabindex="4" required="" text = "Escribe tu mensaje..." TextMode="MultiLine" Rows="5" Columns="40" runat = "server" />
					</label>
				</div>						
				<div>
					<asp:Button ID="send" OnClick = "envio" type="submit" text="Enviar"  runat = "server" />
				</div>

		</div>
	</div>
	</div>
    <div class="clear"></div>
</div>
</div>
</div>
</form>

<div class="footer_bg">
<div class="wrap">
<div class="footer">

	<div class="f_nav1">
		<ul>
			<li><a href="indice.aspx">Inicio/</a></li>
			<li><a href="#">Términos y condiciones /</a></li>
			<li><a href="#">Contáctanos</a></li>
		</ul>
		</div>
	
	<div class="clear"></div>
</div>
</div>
</div>
</asp:Content>