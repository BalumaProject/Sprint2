<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.Catalogo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

  
  <script type="text/javascript" src="http://code.jquery.com/jquery-latest.min.js"></script>
  <script type="text/javascript" src="slider/jquery.slides.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="main_bg">
<div class="wrap">
<div class="main">

<div id="slides">
  <img src="Content/images/bavaria.jpg" alt="">
  <img src="Content/images/bavaria.jpg" alt="">
</div>
    <div class="clear"></div>
	<div class="clear"></div>
</div>
</div>
</div>
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
