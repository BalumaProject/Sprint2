using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BalumaProjectGenNHibernate.CEN.BalumaProject;
using BalumaProjectGenNHibernate.EN.BalumaProject;

namespace BalumaProject_Plantilla_Frontend
{
    public partial class Catalogo : System.Web.UI.Page
    {
        public string content;
        private string prod_nombre;
        private float prod_precio;
        private ProductoCEN productos = new ProductoCEN();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            IList<ProductoEN> lista_productos = new List<ProductoEN>();
          
            /*
             * Al cargar, la página debe leer los productos que se encuentran disponibles en stock de la
             * base de datos y colocarlos dinámicamente en una tabla
             * */

           lista_productos = productos.DameTodosLosProductos(0, 100);
            crea_contenido(lista_productos);
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
                lista_busqueda = productos.DamePorCategoria(opcion);
            }
            else if (precio.Text!=null||!precio.Text.Equals(""))
            {
                price = float.Parse(precio.Text);
                lista_busqueda = productos.DamePorPrecio(price);
            }
            else 
            {
                price = float.Parse(precio.Text);
                lista_busqueda = productos.DamePorCategoriayPrecio(opcion,price);
            }

            if (lista_busqueda == null || lista_busqueda.Count == 0) encontrado = false;
            if (encontrado) { crea_contenido(lista_busqueda); }
            else contenido_no_encontrado();
           
           
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
                    content += "<div class=\"grids_of_3\">";
                    cuenta_trío = 0;
                }
                content += "<div class=\"grid1_of_3\">";
                prod_nombre = prod.Nombre;
                prod_precio = prod.Precio;
                content += "<a href=\"details.html\"> <img src=\"Content/images/bavaria.jpg\" alt=\"\"/><h3>" + prod_nombre + "</h3> <span class=\"price\">" + prod_precio + "€</span> </a> </div> ";
                cuenta_trío++;
               
            }
            content += "</div><div class=\"clear\"></div>"; //fin de envoltura
        }
        private void contenido_no_encontrado()
        {

        }

    }
}