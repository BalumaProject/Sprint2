﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using BalumaProjectGenNHibernate.CEN.BalumaProject;
using System.Web.UI.HtmlControls;
namespace WebApplication1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public HtmlGenericControl HtmlGenericControl
        {
            get { return cantidad; }
        }
    }
}