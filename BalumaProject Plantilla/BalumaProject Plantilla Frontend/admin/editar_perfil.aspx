<%@ Page Language="C#" MasterPageFile="~/admin/Administrador.Master" AutoEventWireup="true" CodeBehind="editar_perfil.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.admin.editar_perfil" %>

<%@ Register TagPrefix="uc" TagName="Footer" Src="~/_footer.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headAdmin" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="registration_left medio_tam">
        <div class="registration_form">
            <!-- Form -->
            <form runat="server">
                <div>
                    Nombre: <asp:TextBox ID="Nombre" type="text" runat="server" /><br />
                    Nickname: <asp:TextBox ID="Nickname" Type="text"  runat="server" /><br />
                    Apellidos: <asp:TextBox ID="Apellidos" Type="text" runat="server" /><br />
                    Contraseña: <asp:TextBox ID="Password" Type="text" placeholder="contraseña" runat="server" /><br />
                    Repite Contraseña: <asp:TextBox ID="PasswordConfirmation" placeholder="repite tu contraseña" runat="server" />
                    <asp:CustomValidator ErrorMessage="Las contraseñas no coinciden" 
                        OnServerValidate="MismoPassword" Display="Dynamic"
                        ControlToValidate="PasswordConfirmation" runat="server" />
                    <br />
                    <asp:Button ID="Button1" OnClick="EditarAdmin" Text="Actualiza tus datos" runat="server" />
                </div>
            </form>
            <!-- /Form -->
        </div>
    </div>
    <uc:Footer ID="footer"
        runat="server" />
</asp:Content>


