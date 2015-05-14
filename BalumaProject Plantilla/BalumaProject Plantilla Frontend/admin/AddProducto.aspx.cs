using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BalumaProjectGenNHibernate.CEN.BalumaProject;

namespace BalumaProject_Plantilla_Frontend.admin
{
    public partial class AddProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CrearProducto(object sender, EventArgs e)
        {
            var cad = new ProductoCEN();
            var productos = cad.DameTodosLosProductos(0, 100);
            var id = productos.Max(p => p.IdProducto) + 1;
            cad.CrearProducto(id, float.Parse(Precio.Text), "admin", Categoria.SelectedItem.Text.ToLower(), 
                Nombre.Text, int.Parse(Cantidad.Text));
            Response.Redirect("AdministrarProductos.aspx");
        }
    }
}