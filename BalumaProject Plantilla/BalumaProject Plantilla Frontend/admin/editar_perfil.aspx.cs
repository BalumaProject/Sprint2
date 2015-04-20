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
        UsuarioCEN usuario = new UsuarioCEN();
        
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void editar_admin(object sender, EventArgs ev)
        {
            AdministradorEN ad = (AdministradorEN)Session["admin"];
            String apellidos = prapellido.Text + sgapellido.Text;
            admin.ModifcarAdministrador(ad.NIF,apellidos,pass.Text,nickname.Text,nombre.Text);
        }
    }
}