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
                pedCen.CrearPedido(7, DateTime.Now, EstadoPedidoEnum.en_curso, TipoPagoEnum.paypal, "admin", cliente.NIF);
                LineaPedidoCEN licen = new LineaPedidoCEN();
                int numLinea = 0;
                foreach(ProductoEN prod in pedido)
                {
                    licen.CrearLinea(prod.IdProducto, 7, numLinea);
                    numLinea++;
                }
                Session["cliente"] = cliente;

            }
            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc,
                                        new FileStream(@"C:\prueba.pdf", FileMode.Create));

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Factura");
            doc.AddCreator("BalumaProject");

            // Abrimos el archivo
            doc.Open();

            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(@"C:\logoweb.png");
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

            Paragraph linea1 = new Paragraph();

            // Escribimos el encabezamiento en el documento
            linea1.Add(new Chunk("FECHA DE EXPEDICIÓN:", _boldFont));
            linea1.Add(new Chunk(hoy.ToString(), _standardFont));

            Paragraph linea2 = new Paragraph();

            doc.Add(new Chunk("FECHA DE VENCIMIENTO:", _boldFont));
            doc.Add(new Chunk(fin.ToString(), _standardFont));

            doc.Add(linea2);

            Paragraph linea3 = new Paragraph();

            doc.Add(new Paragraph("CLIENTE:", _boldFont));

            doc.Add(linea3);

            Paragraph linea4 = new Paragraph();

            doc.Add(new Paragraph("DIRECCIÓN:", _boldFont));

            doc.Add(linea4);

            Paragraph linea5 = new Paragraph();

            doc.Add(new Paragraph("TEL:", _boldFont));

            doc.Add(linea5);

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

            IList<ProductoEN> p = new List<ProductoEN>();
            
            p = (IList<ProductoEN>)Session["carrito"];
            
            foreach (ProductoEN producto in p)
            {
                
                // Llenamos la tabla con información
                clCantidad = new PdfPCell(new Phrase("Hola", _standardFont));
                clCantidad.BorderWidth = 0;
                
                clDescrp = new PdfPCell(new Phrase("soy", _standardFont));
                clDescrp.BorderWidth = 0;
                
                clPrecio = new PdfPCell(new Phrase("Epi", _standardFont));
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
            
            Response.Redirect("Catalogo.aspx");
        }

        protected IList<ProductoEN> ObtenerProductos()
        {

            return (IList<ProductoEN>)Session["carrito"];
        }

        private void Eliminar()
        {
            var id = int.Parse(Request["id"]);
          
         //   cen.BorrarProducto(id,);
            Response.Redirect("factura.aspx");
        }
    }
}