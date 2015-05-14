<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form id="Form1"  runat = "server">
<div class="main_bg">
<div class="wrap">
<div class="main">

	<div class="login_left">
		<h3>login</h3>
		<p>Si ya tienes una cuenta con nosotros, loguéate y disfruta de nuestra gran variedad de productos para barcos</p>
	<!-- start registration -->
	<div class="registration">
		
		

	<div class="registration_left">
		
		 <div class="registration_form">
		 <!-- Form -->
			
				<div>
					<label>
						<asp:TextBox ID = "usname" type="text" tabindex="3" required="" text = "usuario" runat="server" />
					</label>
				</div>
				<div>
					<label>
						<asp:TextBox  ID = "password" type="password" tabindex="4" text="contraseña" runat = "server" />
					</label>
				</div>						
				<div>
					<asp:Button OnClick = "login" type="submit" text="¡Entra!"  runat = "server" />
				</div>
				<div class="forget">
					<a href="#">¿No recuerdas tu contraseña?</a>
				</div>
			
			<!-- /Form -->
		</div>
	</div>
	</div>
	<!-- end registration -->
	</div>
	<div class="login_left">
		<h3>Regístrate</h3>
		<p>Si creas una cuenta cliente, podrás comprar nuestros productos de la tienda, hacer un seguimiento de los pedidos y encargar productos que ya no se encuentren en stock.</p>
		<div class="registration_left">
		
		 <div class="registration_form">
		 <!-- Form -->
				<div>
					<label>
						<asp:TextBox ID = "nickname" type="text" tabindex="0" placeholder="Nombre de usuario:" runat = "server"  />
					</label>
				</div>
			
				<div>
					<label>
						<asp:TextBox ID = "nombre" type="text" tabindex="1" placeholder="Nombre:" runat = "server"  />
					</label>
				</div>
				<div>
					<label>
						<asp:TextBox ID = "papellido" type="text" tabindex="2" placeholder="Primer apellido:" runat = "server" />
					</label>
				</div>

				<div>
					<label>
						<asp:TextBox ID = "sapellido" placeholder="Segundo apellido:" type="text" tabindex="3" runat="server" />
					</label>
				</div>

				
				<div>
					<label>
						<asp:TextBox ID = "email" placeholder="Email:" type="email" tabindex="4" runat="server" />
					</label>
				</div>

                	
				<div>
					<label>
						<asp:TextBox ID = "nif" placeholder="NIF:" type="text" tabindex="5" runat="server" />
					</label>
				</div>

                	
				<div>
					<label>
						<asp:TextBox ID = "local" placeholder="localidad:" type="text" tabindex="6" runat="server" />
					</label>
				</div>

                <div>
					<label>
						<asp:TextBox ID = "cp" placeholder="C.P:" type="text" tabindex="7" runat="server" />
					</label>
				</div>
                	
				<div>
					<label>
						<asp:TextBox ID = "telf" placeholder="número de teléfono:" type="text" tabindex="8" runat="server" />
					</label>
				</div>

                	
				<div>
					<label>
						<asp:TextBox ID = "cuenta" placeholder="cuenta bancaria:" type="text" tabindex="9" runat="server" />
					</label>
				</div>

				<div>
					<label>
						<asp:TextBox ID = "pass" placeholder="contraseña" type="password" tabindex="10" runat="server" />
					</label>
				</div>						
				<div>
					<label>
						<asp:TextBox placeholder="repite la contraseña" type="password" tabindex="11" runat="server" />
					</label>
				</div>	
				<div>
					<asp:Button OnClick = "register_submit" type="submit" text="Crea tu cuenta" runat="server" />
				</div>
				<div class="sky_form">
					<label class="checkbox"><asp:CheckBox name="checkbox" runat="server"/><i>Estoy de acuerdo con los <a class="terms" href="#"> términos de servicio</a> </i></label>
				</div>
			
			<!-- /Form -->
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
