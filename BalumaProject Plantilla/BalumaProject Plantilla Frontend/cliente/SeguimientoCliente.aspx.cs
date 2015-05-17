using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BalumaProjectGenNHibernate.CEN.BalumaProject;
using BalumaProjectGenNHibernate.EN.BalumaProject;
namespace BalumaProject_Plantilla_Frontend.cliente
{
    
    public partial class SeguimientoCliente : System.Web.UI.Page
    {
        ClienteEN cli;
        protected void Page_Load(object sender, EventArgs e)
        {
            cli = (ClienteEN)Session["cliente"];

        }
        protected IList<PedidoEN> ObtenerPedidos()
        {
            var cenPedido = new PedidoCEN();
            return cenPedido.ObtenerPorCliente(cli.NIF);
        }

        
    }
}