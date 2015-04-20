using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;
using System.Net.Mail;

namespace BalumaProject_Plantilla_Frontend
{
    public partial class contacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void envio(object sender, EventArgs e)
        {
            SendMail();
        }

        private void SendMail()
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add("javinformaticaua@gmail.com");
            msg.From = new MailAddress("balumaproject@gmail.com", nombre.Text, System.Text.Encoding.UTF8);
            msg.Subject = tema.Text;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = mensaje.Text + "\n" + "El correo de contacto es: " + email.Text;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = false;

            //Aquí es donde se hace lo especial
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("balumaproject@gmail.com", "baluma2015");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true; //Esto es para que vaya a través de SSL que es obligatorio con GMail
            try
            {
                client.Send(msg);
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}