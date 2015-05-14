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
    public partial class EliminarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["id"] != null)
            {
                Eliminar();
            }
        }

        protected IList<ProductoEN> ObtenerProductos()
        {
            var p = new ProductoCEN();
            return p.DameTodosLosProductos(0, 100);
        }

        private void Eliminar()
        {
            var id = int.Parse(Request["id"]);
            var cen = new ProductoCEN();
            cen.BorrarProducto(id);
            Response.Redirect("EliminarProducto.aspx");
        }
    }
}