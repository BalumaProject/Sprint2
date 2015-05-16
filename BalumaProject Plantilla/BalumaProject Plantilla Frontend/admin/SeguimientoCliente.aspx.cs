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
    public partial class SeguimientoCliente : System.Web.UI.Page
    {
        protected ClienteEN _cliente;
        private ClienteCEN _clienteCen;
        private int _idCliente;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["id"] != null)
            {
                _idCliente = int.Parse(Request["id"]);
                _clienteCen = new ClienteCEN();
                _cliente = _clienteCen.Obtener(Request["id"]);
            }
        }

        protected IList<PedidoEN> ObtenerPedidos()
        {
            var cen = new PedidoCEN();
            return cen.ObtenerPorCliente(Request["id"]);
        }

        protected ClienteEN ObtenerCliente()
        {
            var cen = new ClienteCEN();
            var id = Request["id"];
            return cen.Obtener(id);
        }
    }
}