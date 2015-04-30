<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Generico.Master" AutoEventWireup="true" CodeBehind="LoginAdmin.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.admin.LoginAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="registration_form">
            <div class="medio-tam">
                <!-- Form -->
				<div>
					<label>
						<asp:TextBox ID = "username" type="text" tabindex="1" placeholder="Nombre de usuario:" runat="server" />
					</label>
				</div>
				<div>
					<label>
						<asp:TextBox ID = "password" placeholder="Contraseña:" type="password" tabindex="2" runat="server" />
					</label>
				</div>						
				<div>
					<asp:Button OnClick = "login" type="submit" text="¡Entra!" runat = "server"/>
				</div>
			<!-- /Form -->
            </div>		 
		</div>
    </div>
</asp:Content>
