<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="about.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.about" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="Form1"  runat = "server">
<div class="main_bg">
<div class="wrap">
<div class="main">

    <div class="login_left">
		<h3>¿Quiénes somos?</h3>
        <p>
        Somos una empresa de la zona de Alicante, con experiencia en el sector
        textil. Concretamente, nos dedicamos a la elaboración de velas para barcos,
        ya sean pequeños veleros o buques de mayor tamaño.
        </p>
	</div>

    <div class="login_left">
		<h3>Así trabajamos</h3>
		<div class="registration_left">    
            <!-- 16:9 aspect ratio -->
            <div class="responsive-video">
                    <iframe width="560" height="315" src="https://www.youtube.com/embed/hfIFiFbtziA?list=PLk53N9s3Tc85wD5tgiR_nmnAriz0pYlG_" frameborder="0" allowfullscreen></iframe>
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
