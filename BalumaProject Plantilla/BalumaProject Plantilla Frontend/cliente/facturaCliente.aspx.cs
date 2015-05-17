using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using BalumaProjectGenNHibernate.EN.BalumaProject;
using BalumaProjectGenNHibernate.CEN.BalumaProject;
using System.Web.UI.HtmlControls;
using BalumaProjectGenNHibernate.Enumerated.BalumaProject;
namespace BalumaProject_Plantilla_Frontend
{
    public partial class facturaCliente : System.Web.UI.Page
    {
        bool user_loged = false;
        IList<ProductoEN> pedido = new List<ProductoEN>();
        void Page_PreInit(object sender, EventArgs e)
        {
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["carrito"] != null)
            {
                pedido = (IList<ProductoEN>)Session["carrito"];
            }
            if(pedido != null) Master.HtmlGenericControl.InnerText = pedido.Count.ToString();
            if (Request["id"] != null)
            {
                Eliminar();
            }
            if (Session["cliente"] != null)
            {
                user_loged = true;
            }
        }

        protected void generar_factura(object sender, EventArgs e)
        {
            if (user_loged == false)
            {

                Response.Redirect("registro.aspx");
            }
            else
            {
               
                ClienteEN cliente = (ClienteEN)Session["cliente"];
                ClienteCEN cliCen = new ClienteCEN();
                PedidoCEN pedCen = new PedidoCEN();
                if (RadioButtonList1.SelectedItem.ToString().ToLower() == "paypal") pedCen.CrearPedido(DateTime.Now, EstadoPedidoEnum.en_curso, TipoPagoEnum.paypal, "admin", cliente.NIF);
                if (RadioButtonList1.SelectedItem.ToString().ToLower() == "visa") pedCen.CrearPedido(DateTime.Now, EstadoPedidoEnum.en_curso, TipoPagoEnum.visa, "admin", cliente.NIF);
               
                 
                    IList<PedidoEN> pedEn = pedCen.ObtenerPorCliente(cliente.NIF);
                    pedCen.Comprar(pedEn.ElementAt(pedEn.Count - 1).IdPedido, pedido);
                    Session["cliente"] = cliente;
              
            }
            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc,
                                        new FileStream(@"D:\prueba.pdf", FileMode.Create));

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Factura");
            doc.AddCreator("BalumaProject");

            // Abrimos el archivo
            doc.Open();

            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(@"D:\logoweb.png");
            imagen.BorderWidth = 0;
            imagen.Alignment = Element.ALIGN_RIGHT;
            float percentage = 0.0f;
            percentage = 150 / imagen.Width;
            imagen.ScalePercent(percentage * 100);

            doc.Add(imagen);

            // Creamos el tipo de Font que vamos utilizar
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font _boldFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

            DateTime hoy = DateTime.Today;
            DateTime fin = new DateTime(2015, 5, 18);

            ClienteEN cli = (ClienteEN)Session["cliente"];

            Paragraph linea1 = new Paragraph();

            // Escribimos el encabezamiento en el documento
            linea1.Add(new Chunk("FECHA DE EXPEDICIÓN: ", _boldFont));
            linea1.Add(new Chunk(hoy.ToString(), _standardFont));

            doc.Add(linea1);

            Paragraph linea2 = new Paragraph();

            doc.Add(new Chunk("FECHA DE VENCIMIENTO: ", _boldFont));
            doc.Add(new Chunk(fin.ToString(), _standardFont));

            doc.Add(linea2);

            Paragraph linea3 = new Paragraph();

            doc.Add(new Chunk("CLIENTE: ", _boldFont));
            doc.Add(new Chunk(cli.Nombre.ToString() + cli.Apellidos.ToString(), _standardFont));

            doc.Add(linea3);

            Paragraph linea4 = new Paragraph();

            doc.Add(new Chunk("NIF: ", _boldFont));
            doc.Add(new Chunk(cli.NIF, _standardFont));

            doc.Add(linea4);

            Paragraph linea5 = new Paragraph();

            doc.Add(new Chunk("DIRECCIÓN: ", _boldFont));
            doc.Add(new Chunk(cli.Localidad.ToString(), _standardFont));

            doc.Add(linea5);

            Paragraph linea6 = new Paragraph();

            doc.Add(new Chunk("E-MAIL: ", _boldFont));
            doc.Add(new Chunk(cli.Email.ToString(), _standardFont));

            doc.Add(linea6);

            doc.Add(Chunk.NEWLINE);


            // Creamos una tabla que contendrá el nombre, apellido y país
            // de nuestros visitante.
            PdfPTable tbl1 = new PdfPTable(3);
            tbl1.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clCantidad = new PdfPCell(new Phrase("CANTIDAD", _boldFont));
            clCantidad.BorderWidth = 0;
            clCantidad.BorderWidthBottom = 0.75f;

            PdfPCell clDescrp = new PdfPCell(new Phrase("DESCRIPCIÓN", _boldFont));
            clDescrp.BorderWidth = 0;
            clDescrp.BorderWidthBottom = 0.75f;

            PdfPCell clPrecio = new PdfPCell(new Phrase("PRECIO", _boldFont));
            clPrecio.BorderWidth = 0;
            clPrecio.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tbl1.AddCell(clCantidad);
            tbl1.AddCell(clDescrp);
            tbl1.AddCell(clPrecio);

           
            
            foreach (ProductoEN producto in pedido)
            {
                
                // Llenamos la tabla con información
                clCantidad = new PdfPCell(new Phrase(producto.Cantidad.ToString(), _standardFont));
                clCantidad.BorderWidth = 0;
                
                clDescrp = new PdfPCell(new Phrase(producto.Nombre.ToString(), _standardFont));
                clDescrp.BorderWidth = 0;
                
                clPrecio = new PdfPCell(new Phrase(producto.Precio.ToString(), _standardFont));
                clPrecio.BorderWidth = 0;
                
                // Añadimos las celdas a la tabla
                tbl1.AddCell(clCantidad);
                tbl1.AddCell(clDescrp);
                tbl1.AddCell(clPrecio);
            }

            doc.Add(tbl1);

            PdfPTable tbl2 = new PdfPTable(3);
            tbl2.WidthPercentage = 100;

            PdfPCell clb1 = new PdfPCell(new Phrase(" ", _standardFont));
            clb1.BorderWidth = 0;
            clb1.BorderWidthBottom = 0.75f;

            PdfPCell clb2 = new PdfPCell(new Phrase(" ", _standardFont));
            clb2.BorderWidth = 0;
            clb2.BorderWidthBottom = 0.75f;

            PdfPCell clTotal = new PdfPCell(new Phrase("TOTAL (+ IVA)", _boldFont));
            clTotal.BorderWidth = 0;
            clTotal.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tbl2.AddCell(clb1);
            tbl2.AddCell(clb2);
            tbl2.AddCell(clTotal);

            /*FacturaCEN factura = new FacturaCEN();
            factura.CrearFactura(0);*/
            clb1 = new PdfPCell(new Phrase(" ", _standardFont));
            clb1.BorderWidth = 0;
             clb2 = new PdfPCell(new Phrase(" ", _standardFont));
            clb2.BorderWidth = 0;
            clTotal = new PdfPCell(new Phrase(calculoTotal(pedido).ToString(), _standardFont));
            clTotal.BorderWidth = 0;
            tbl2.AddCell(clb1);
            tbl2.AddCell(clb2);
            tbl2.AddCell(clTotal);

            doc.Add(tbl2);

            doc.Add(new Phrase("EMPRESA:" + "                   " + "RECIBÍ A CONFORMIDAD:", _standardFont));
            
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(@"C:\firma.jpg");
            imagen.BorderWidth = 0;
            imagen.Alignment = Element.ALIGN_LEFT;
            float per = 0.0f;
            per = 150 / imagen.Width;
            imagen.ScalePercent(percentage * 100);

            doc.Add(img);

            doc.Close();
            writer.Close();
        }

        protected void continuar(object sender, EventArgs e)
        {
            
            Response.Redirect("CatalogoCliente.aspx");
        }

        protected IList<ProductoEN> ObtenerProductos()
        {

            return (IList<ProductoEN>)Session["carrito"];
        }
        private float calculoTotal(IList<ProductoEN> productos)
        {
            float suma = 0.0f;
            float precio = 0.0f;
            foreach (ProductoEN pd in productos)
            {
                precio = pd.Precio;
                suma += precio;
            }

                return suma;
        }
        private void Eliminar()
        {
            var id = int.Parse(Request["id"]);
          
         //   cen.BorrarProducto(id,);
            Response.Redirect("factura.aspx");
        }
    }
}