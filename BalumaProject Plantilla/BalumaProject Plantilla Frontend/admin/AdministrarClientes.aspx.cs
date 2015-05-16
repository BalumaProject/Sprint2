using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BalumaProjectGenNHibernate.EN.BalumaProject;
using BalumaProjectGenNHibernate.CEN.BalumaProject;

namespace BalumaProject_Plantilla_Frontend.admin
{
    public partial class AdministrarClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("~/admin/LoginAdministrador.aspx");
            }
        }

        protected IList<ClienteEN> ObtenerClientes()
        {
            var cen = new ClienteCEN();
            return cen.ObtenerTodos(0, 100);
        }

        
    }
}