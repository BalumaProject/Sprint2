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
    public partial class AdministrarClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("~/admin/LoginAdministrador.aspx");
            }
        }

        protected IList<ClienteEN> ObtenerClientes()
        {
            var clientes = new List<ClienteEN>();
            var usuCen = new UsuarioCEN();
            var nombres = new List<string>(){
                "cliente1",
                "cliente2",
                "cliente3",
                "cliente4"
            };

            nombres.ForEach(n =>
            {
                var usu = usuCen.LeerPorNombreCliente(n);
                if (usu is ClienteEN)
                {
                    var c = (ClienteEN)usu;
                    clientes.Add(c);
                }
            });

            return clientes;
        }
    }
}