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
    public partial class EditarProducto : System.Web.UI.Page
    {
        protected string _nombre;
        protected ProductoEN _p;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                _nombre = Request["nombre"];
                var cen = new ProductoCEN();
                _p = cen.DamePorNombre(_nombre).ElementAt(0);
                InformacionActual();

            }
        }

        protected void Actualizar(object sender, EventArgs e)
        {
            var cen = new ProductoCEN();
            cen.ModificarProducto(int.Parse(Request["id"]), float.Parse(Precio.Text), Nombre.Text, int.Parse(Cantidad.Text));
            Response.Redirect("AdministrarProductos.aspx");
        }

        private void InformacionActual()
        {
            Nombre.Text = _p.Nombre;
            Precio.Text = _p.Precio.ToString();
            Cantidad.Text = _p.Cantidad.ToString();
        }
    }
}