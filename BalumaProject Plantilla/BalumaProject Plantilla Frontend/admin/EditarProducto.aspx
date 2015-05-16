<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Administrador.Master" AutoEventWireup="true"
    CodeBehind="EditarProducto.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.admin.EditarProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headAdmin" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
    <div class="content">
        <div class="form-group">
            <label for="Nombre">
                Nombre</label>
            <asp:TextBox ID="Nombre" CssClass="form-control" type="text" runat="server" />
        </div>
        <div class="form-group">
            <label for="Precio">
                Precio</label>
            <asp:TextBox ID="Precio" CssClass="form-control" runat="server" />
        </div>
        <div class="form-group">
            <label for="Cantidad">
                Cantidad</label>
            <asp:TextBox ID="Cantidad" CssClass="form-control" runat="server" />
        </div>
        <asp:Button ID="Button1" Text="Actualizar" OnClick="Actualizar" CssClass="btn btn-default"
            runat="server" />
    </div>
    </form>
</asp:Content>
