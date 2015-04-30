<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginAdministrador.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.admin.LoginAdministrador" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href='http://fonts.googleapis.com/css?family=Maven+Pro:400,900,700,500' rel='stylesheet' type='text/css' />
    <link href="~/Content/css/style.css" rel="stylesheet" type="text/css" media="all" />
    <script src="~/Scripts/jquery.min.js" type="text/javascript"></script>
    <link type="text/css" rel="stylesheet" href="../Content/css/jquery.mmenu.all.css"/>
    <script type="text/javascript" src="~/Scripts/jquery.mmenu.js"></script>
    <link type="text/css" rel="stylesheet" href="~/Content/css/Estilos.css"/>

</head>
<body>
    <form id="form1" runat="server">
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
    </form>
</body>
</html>
