﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BalumaProjectGenNHibernate.EN.BalumaProject;
using System.Web.UI.HtmlControls;

namespace BalumaProject_Plantilla_Frontend
{
    public partial class about : System.Web.UI.Page
    {

        void Page_PreInit(object sender, EventArgs e)
        {
           
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            IList<ProductoEN> pedido = (IList<ProductoEN>)Session["carrito"];
            if (pedido != null) Master.HtmlGenericControl.InnerText = pedido.Count.ToString();

        }
    }
}