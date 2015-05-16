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
        protected ClienteEN _cliente;
        protected string _id;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["id"] != null)
            {
                _id = Request["id"];
                var cen = new ClienteCEN();
                _cliente = cen.Obtener(_id);
            }
        }

        protected IList<PedidoEN> ObtenerPedidos()
        {
            var cenPedido = new PedidoCEN();
            return cenPedido.ObtenerPorCliente(_id);
        }

        protected void VolverClientes(object sender, EventArgs e)
        {
            Response.Redirect("~/admin/AdministrarClientes.aspx");
        }
    }
}