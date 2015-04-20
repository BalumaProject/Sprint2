<%@ Page Language="C#" MasterPageFile="~/admin/Administrador.Master" AutoEventWireup="true" CodeBehind="editar_perfil.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.admin.editar_perfil" %>
<%@ Register TagPrefix="uc" TagName="Footer" Src="~/_footer.ascx"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="headAdmin" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="registration_left medio_tam">
        <div class="registration_form">
		 <!-- Form -->
         <form runat="server">
				<div>
					<label>
						<asp:TextBox ID = "nombre" type="text" tabindex="1" placeholder="Nombre:" runat = "server"  />
					</label>
				</div>
                <div>
					<label>
						<asp:TextBox ID = "nickname" type="text" tabindex="2" placeholder="Nombre de usuario:" runat = "server"  />
					</label>
				</div>
				<div>
					<label>
						<asp:TextBox ID = "prapellido" type="text" tabindex="3" placeholder="Primer apellido:" runat = "server" />
					</label>
				</div>

				<div>
					<label>
						<asp:TextBox ID = "sgapellido" placeholder="Segundo apellido:" type="text" tabindex="4" runat="server" />
					</label>
				</div>

				<div>
					<label>
						<asp:TextBox ID = "pass" placeholder="Contraseña:" type="password" tabindex="5" runat="server" />
					</label>
				</div>						
				<div>
					<label>
						<asp:TextBox ID="TextBox1" placeholder="Repite la contraseña:" type="password" tabindex="6" runat="server" />
					</label>
				</div>	
				<div>
					<asp:Button ID="edit" OnClick = "editar_admin" text="Actualiza tus datos"  runat = "server" />
				</div>
                </form>
			<!-- /Form -->
		</div>
    </div>
    
    
        <uc:Footer id="footer"
            runat="server" />
</asp:Content>


