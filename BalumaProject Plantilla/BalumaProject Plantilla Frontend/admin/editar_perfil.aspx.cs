using System;
using BalumaProjectGenNHibernate.CEN.BalumaProject;
using BalumaProjectGenNHibernate.EN.BalumaProject;
using System.Web.UI.WebControls;


namespace BalumaProject_Plantilla_Frontend.admin
{
    public partial class editar_perfil : System.Web.UI.Page
    {
        AdministradorCEN admin = new AdministradorCEN();
        UsuarioCEN usuario = new UsuarioCEN();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("LoginAdmin.aspx");
            }

            var admin = GetAdmin();
            Nombre.Text = admin.Nombre;
            Nickname.Text = admin.Username;
            Apellidos.Text = admin.Apellidos;
        }

        protected void EditarAdmin(object sender, EventArgs ev)
        {
            AdministradorEN ad = (AdministradorEN)Session["admin"];
            admin.ModifcarAdministrador(ad.NIF, Apellidos.Text, Password.Text, Nickname.Text, Nombre.Text);
        }

        protected AdministradorEN GetAdmin()
        {
            AdministradorEN admin = (AdministradorEN)Session["admin"];
            return admin;
        }

        protected void MismoPassword(object sender, ServerValidateEventArgs e)
        {
            e.IsValid = false;
            if (Password.Text == PasswordConfirmation.Text)
            {
                e.IsValid = true;
            }
        }
    }
}