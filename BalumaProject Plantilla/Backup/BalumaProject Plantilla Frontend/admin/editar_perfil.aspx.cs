using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BalumaProjectGenNHibernate.CEN.BalumaProject;
using BalumaProjectGenNHibernate.EN.BalumaProject;
using BalumaProjectGenNHibernate.CAD.BalumaProject;
using BalumaProjectGenNHibernate.Enumerated.BalumaProject;


namespace BalumaProject_Plantilla_Frontend.admin
{
    public partial class editar_perfil : System.Web.UI.Page
    {

        AdministradorCEN admin = new AdministradorCEN();
        AdministradorEN ad = new AdministradorEN();
        UsuarioCEN usuario = new UsuarioCEN();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ad = (AdministradorEN)Session["admin"];
                nombre.Text = ad.Nombre;
                nickname.Text = ad.Username;
                string[] apellidos = ad.Apellidos.Split(' ');
                prapellido.Text = apellidos[0];
                //sgapellido.Text = apellidos[1];
                pass.Text = ad.Password;
            }catch (Exception ex)
            {
                Response.Redirect("~/admin/LoginAdministrador.aspx");
            }
            finally
            {

            }            
        }

        protected void editar_admin(object sender, EventArgs ev)
        {
            
            String apellidos = prapellido.Text + sgapellido.Text;
            admin.ModifcarAdministrador(ad.NIF,apellidos,pass.Text,nickname.Text,nombre.Text);
        }
    }
}