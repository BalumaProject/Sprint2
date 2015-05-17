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
            IList<ProductoEN> pedido = (IList<ProductoEN>)Session["carrito"];
            if (pedido != null) Master.HtmlGenericControl.InnerText = pedido.Count.ToString();

             cli = (ClienteEN)Session["cliente"];
             nombre.Text = cli.Nombre;
             nickname.Text = cli.Username;
             local.Text = cli.Localidad;
             cp.Text = cli.CodigoPostal;
             telf.Text = cli.Telefono;
             email.Text = cli.Email;
             cuenta.Text = cli.NumCuentaBancaria;
             string[] apellidos = cli.Apellidos.Split(' ');
             papellido.Text = apellidos[0];
             sapellido.Text = apellidos[1];
             pass.Text = cli.Password;
            
             

        }

        protected void editar(object sender, EventArgs e)
        {
            
            String apellidos = papellido.Text + sapellido.Text;
            cliente.ModificarCliente(cli.NIF,apellidos,pass.Text,nickname.Text,nombre.Text,local.Text,cp.Text,cuenta.Text,telf.Text,email.Text,"url foto sin asignar aún");
            
        }

        protected void baja(object sender, EventArgs e)
        {
            usu.BorrarUsuario(cli.NIF);
        }
       
      
    }
}