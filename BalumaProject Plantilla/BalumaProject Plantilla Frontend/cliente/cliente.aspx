<%@ Page Title="" Language="C#" MasterPageFile="~/cliente/Cliente.Master" AutoEventWireup="true" CodeBehind="cliente.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.cliente.cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headCli" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="main_bg">
<div class="wrap">
<div class="main">
	<div class="top_main">
		<h2>Lo nuevo en Baluma</h2>
		<a href="#">Quiero ver más</a>
		<div class="clear"></div>
	</div>
	<!-- start grids_of_3 -->
	<div class="grids_of_3">
		<div class="grid1_of_3">
			<a href="details.html">
				<img src="../Content/images/bavaria.jpg" alt=""/>
				<h3>Vela clásica</h3>
				<span class="price">$145,99</span>
			</a>
		</div>
		<div class="grid1_of_3">
			<a href="details.html">
				<img src="../Content/images/bavaria.jpg" alt=""/>
				<h3>Vela latina</h3>
				<span class="price">$185,99</span>
			</a>
		</div>
		<div class="grid1_of_3">
			<a href="details.html">
				<img src="../Content/images/bavaria.jpg" alt=""/>
				<h3>Regata 100%</h3>
				<span class="price">$145,99</span>
			</a>
		</div>
		<div class="clear"></div>
	</div>
	<div class="top_main">
		<h2>Lo más vendido éste mes</h2>
		<a href="#">Quiero ver más</a>
		<div class="clear"></div>
	</div>
	<!-- start grids_of_3 -->
	<div class="grids_of_3">
		<div class="grid1_of_3">
			<a href="details.html">
				<img src="../Content/images/bavaria.jpg" alt=""/>
				<h3>Regata</h3>
				<span class="price">$145,99</span>
			</a>
		</div>
		<div class="grid1_of_3">
			<a href="details.html">
				<img src="../Content/images/bavaria.jpg" alt=""/>
				<h3>Crucero</h3>
				<span class="price">$185,99</span>
			</a>
		</div>
		<div class="grid1_of_3">
			<a href="details.html">
				<img src="../Content/images/bavaria.jpg" alt=""/>
				<h3>Vela Ligera</h3>
				<span class="price">$145,99</span>
				<span class="price1 bg1">No en stock</span>
			</a>
		</div>
		<div class="clear"></div>
	</div>
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
			<li><a href="#">Inicio/</a></li>
			<li><a href="#">Términos y condiciones /</a></li>
			<li><a href="#">Contáctanos</a></li>
		</ul>
		</div>
	
	<div class="clear"></div>
</div>
</div>
</div>
</asp:Content>
