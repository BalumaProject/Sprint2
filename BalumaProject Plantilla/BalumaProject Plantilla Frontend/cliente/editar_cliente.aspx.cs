using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BalumaProjectGenNHibernate.CEN.BalumaProject;
using BalumaProjectGenNHibernate.EN.BalumaProject;
using BalumaProjectGenNHibernate.CAD.BalumaProject;

namespace BalumaProject_Plantilla_Frontend.cliente
{
    public partial class editar_cliente : System.Web.UI.Page
    {
        ClienteCEN cliente = new ClienteCEN();
        UsuarioCEN usu = new UsuarioCEN();
        ClienteEN cli;
        protected void Page_Load(object sender, EventArgs e)
        {
             cli = (ClienteEN)Session["cliente"];
        }

        protected void editar(object sender, EventArgs e)
        {
            
            String apellidos = papellido.Text + sapellido.Text;
            cliente.ModificarCliente(cli.NIF,apellidos,pass.Text,nickname.Text,nombre.Text,local.Text,cp.Text,cuenta.Text,telf.Text);
            
        }

        protected void baja(object sender, EventArgs e)
        {
            usu.BorrarUsuario(cli.NIF);
        }
       
      
    }
}