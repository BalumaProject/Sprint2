using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BalumaProjectGenNHibernate.CEN.BalumaProject;
using BalumaProjectGenNHibernate.EN.BalumaProject;
using System.Web.UI.HtmlControls;
namespace BalumaProject_Plantilla_Frontend
{
    public partial class CatalogoCliente : System.Web.UI.Page
    {
        public string content;
        private string prod_nombre;
        private float prod_precio;
        private ProductoCEN productoCen = new ProductoCEN();
        private IList<ProductoEN> carrito;
        protected IList<ProductoEN> productos;
        private int id;
        void Page_PreInit(object sender, EventArgs e)
        {
            if (Session["cliente"] != null)
            {
                this.MasterPageFile = "~/cliente/Cliente.Master";
              
            }
            if (Session["carrito"] == null)
            {
                  carrito = new List<ProductoEN>(); 
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["id"] != null)
            {
                id = int.Parse(Request["id"]);
                ProductoEN prod = productoCen.DamePorOID(id);
                if(Session["carrito"] != null)carrito = (IList<ProductoEN>)Session["carrito"];
                carrito.Add(prod);
                Session["carrito"] = carrito;
                Master.HtmlGenericControl.InnerText = carrito.Count.ToString();
            }
            
           IList<ProductoEN> lista_productos = new List<ProductoEN>();

            /*
             * Al cargar, la página debe leer los productos que se encuentran disponibles en stock de la
             * base de datos y colocarlos dinámicamente en una tabla
             * */

            lista_productos = productoCen.DameTodosLosProductos(0, 100);
            //crea_contenido(lista_productos);
            if (!IsPostBack)
            {
                productos = productoCen.DameTodosLosProductos(0, 100);
            }
            else if (IsPostBack)
            {
                productos = productoCen.DameTodosLosProductos(0, 100);
            }
        }

        protected void BuscarProductos(object sender, EventArgs e)
        {
            var opcion = lista.SelectedItem.Text.ToLower();
            float price;

            if (!opcion.Equals("todos") && precio.Text == String.Empty)
            {
                productos = productoCen.DamePorCategoria(opcion);
            }
            else if (opcion.Equals("todos") && precio.Text != String.Empty)
            {
                price = float.Parse(precio.Text);
                productos = productoCen.DamePorPrecio(price);
            }
            else if (opcion.Equals("todos") && precio.Text == String.Empty)
            {
                productos = productoCen.DameTodosLosProductos(0, 100);
            }
            else
            {
                price = float.Parse(precio.Text);
                productos = productoCen.DamePorCategoriayPrecio(opcion, price);
            }
        }

        protected void buscar_productos(object sender, EventArgs e)
        {
            content = "";
            IList<ProductoEN> lista_busqueda = new List<ProductoEN>();
            bool encontrado = true;
            string opcion = lista.SelectedItem.Text.ToLower();
            float price;
            if (!opcion.Equals("todos") && (precio.Text == null || precio.Text.Equals("")))
            {
                lista_busqueda = productoCen.DamePorCategoria(opcion);
            }
            else if (precio.Text != null || !precio.Text.Equals(""))
            {
                price = float.Parse(precio.Text);
                lista_busqueda = productoCen.DamePorPrecio(price);
            }
            else
            {
                price = float.Parse(precio.Text);
                lista_busqueda = productoCen.DamePorCategoriayPrecio(opcion, price);
            }

            if (lista_busqueda == null || lista_busqueda.Count == 0) encontrado = false;
            if (encontrado) { crea_contenido(lista_busqueda); }
            else contenido_no_encontrado();


        }

        protected IList<ProductoEN> ObtenerProductos()
        {
            return productos;
        }

        private void crea_contenido(IList<ProductoEN> lista_contenido)
        {

            int cuenta_trío = 0;

            content += "<div class=\"grids_of_3\">"; //envoltura por cada trío de productos

            foreach (ProductoEN prod in lista_contenido)
            {
                if (cuenta_trío == 3)
                {
                    content += "<div class=\"clear\"></div>";

                    content += "<div class=\"grids_of_3 \">";
                    cuenta_trío = 0;
                }

                content += "<div class=\"grid1_of_3\">";
                prod_nombre = prod.Nombre;
                prod_precio = prod.Precio;
                content += "<a href=\"details.html\"> <img src=\"Content/images/bavaria.jpg\" alt=\"\"/><h3>" + prod_nombre + "</h3> <span class=\"price\">" + prod_precio + "€</span> </a>  ";

                content += "<button OnServerClick = \"anyadeCarrito\">Añadir al carrito</button>";

                content += "</div>";
                cuenta_trío++;

            }
            content += "</div><div class=\"clear\"></div>"; //fin de envoltura
        }
        private void contenido_no_encontrado()
        {

        }

        protected void anyadeCarrito(object sender, CommandEventArgs e)
        {
          /*   Button btn = (Button)sender;
             string index = e.CommandName.ToString();
             IList<ProductoEN> prods = productoCen.DamePorNombre(index);
             prods.ElementAt(0);
           /*   CarritoEN carriEN = new CarritoEN();

              carriEN=carrito.AnyadirProducto(carriEN.IdCarrito,productos.ElementAt(indice));
              Master.HtmlGenericControl.InnerText = carriEN.cantidad;
             */

           
        }

    }
}

