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
    public partial class Seguimiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected IList<ClienteEN> ObtenerClientes()
        {
            var clienteCen = new ClienteCEN();
            return clienteCen.ObtenerTodos(0, 100);
        }
    }
}