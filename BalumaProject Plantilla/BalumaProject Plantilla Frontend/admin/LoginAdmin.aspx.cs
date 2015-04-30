using BalumaProjectGenNHibernate.CEN.BalumaProject;
using BalumaProjectGenNHibernate.EN.BalumaProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BalumaProject_Plantilla_Frontend.admin
{
    public partial class LoginAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login(object sender, EventArgs ev)
        {
            UsuarioCEN u = new UsuarioCEN();
            UsuarioEN us = new UsuarioEN();

            us = u.LeerPorNombreAdministrador(username.Text);

            if (us != null && us.Password == password.Text)
            {
                AdministradorEN ad = new AdministradorEN();
                ad = (AdministradorEN)us;
                Session["admin"] = ad;
                // Response.Redirect("http://localhost:58172/admin/indiceAdmin.aspx");
                Response.Redirect("~/admin/indiceAdmin.aspx");
            }
            else
            {
                //Response.Redirect("http://localhost:58172/indice.aspx");
                Response.Redirect("~/indice.aspx");
            }
        }
    }
}