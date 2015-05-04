using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BalumaProjectGenNHibernate.EN.BalumaProject;
namespace BalumaProject_Plantilla_Frontend.admin
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        AdministradorEN admin;
        protected void Page_Load(object sender, EventArgs e)
        {
            admin = (AdministradorEN)Session["admin"];

        }
    }
}