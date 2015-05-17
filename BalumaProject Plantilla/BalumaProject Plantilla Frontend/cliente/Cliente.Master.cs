using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BalumaProjectGenNHibernate.EN.BalumaProject;
using System.Web.UI.HtmlControls;
namespace BalumaProject_Plantilla_Frontend.cliente
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        ClienteEN cli;
        protected void Page_Load(object sender, EventArgs e)
        {
            cli = (ClienteEN)Session["cliente"];
            nombre_usu.Text = cli.Username;
        }
        public HtmlGenericControl HtmlGenericControl
        {
            get { return cantidad; }
        }
    }
}