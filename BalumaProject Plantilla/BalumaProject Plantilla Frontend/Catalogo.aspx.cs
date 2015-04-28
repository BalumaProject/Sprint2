using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace BalumaProject_Plantilla_Frontend
{
    public partial class Catalogo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string key = "slides";
            string javascript = "$(\"#slides\").slidesjs({ width: 375, height: 500, start: 1});";

            if (!Page.ClientScript.IsStartupScriptRegistered(key))
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), key, javascript, true);
            }
        }
    }
}