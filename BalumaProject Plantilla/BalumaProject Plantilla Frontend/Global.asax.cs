using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace BalumaProject_Plantilla_Frontend
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterCustomRoutes(RouteTable.Routes);
        }

        void RegisterCustomRoutes(RouteCollection r)
        {
            r.MapPageRoute(
                "Root",
                "",
                "~/indice.aspx"
            );

            r.MapPageRoute(
                "LoginAdmin",
                "LoginAdmin",
                "~/admin/LoginAdmin.aspx"
            );

            r.MapPageRoute(
                "AddProducto",
                "AddProducto",
                "~/admin/AddProducto.aspx"
            );

            r.MapPageRoute(
                "QuitarProducto",
                "QuitarProducto",
                "~/admin/QuitarProducto.aspx"
            );
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}