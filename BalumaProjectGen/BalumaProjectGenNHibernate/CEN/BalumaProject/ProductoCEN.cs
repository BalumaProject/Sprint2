

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using BalumaProjectGenNHibernate.EN.BalumaProject;
using BalumaProjectGenNHibernate.CAD.BalumaProject;

namespace BalumaProjectGenNHibernate.CEN.BalumaProject
{
    public partial class ProductoCEN
    {
        private IProductoCAD _IProductoCAD;

        public ProductoCEN()
        {
            this._IProductoCAD = new ProductoCAD();
        }

        public ProductoCEN(IProductoCAD _IProductoCAD)
        {
            this._IProductoCAD = _IProductoCAD;
        }

        public IProductoCAD get_IProductoCAD()
        {
            return this._IProductoCAD;
        }


        public int CrearProducto(int p_idProducto, float p_precio, string p_administrador, string p_categoria, int p_lineaPedido, string p_nombre, int p_cantidad)
        {
            ProductoEN productoEN = null;
            int oid;

            //Initialized ProductoEN
            productoEN = new ProductoEN();
            productoEN.IdProducto = p_idProducto;

            productoEN.Precio = p_precio;


            if (p_administrador != null)
            {
                productoEN.Administrador = new BalumaProjectGenNHibernate.EN.BalumaProject.AdministradorEN();
                productoEN.Administrador.NIF = p_administrador;
            }



            if (p_categoria != null)
            {
                productoEN.Categoria = new BalumaProjectGenNHibernate.EN.BalumaProject.CategoriaEN();
                productoEN.Categoria.Nombre = p_categoria;
            }


            if (p_lineaPedido != -1)
            {
                //productoEN.LineaPedido = new BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN();
                //productoEN.LineaPedido.Numero = p_lineaPedido;
            }

            productoEN.Nombre = p_nombre;

            productoEN.Cantidad = p_cantidad;

            //Call to ProductoCAD

            oid = _IProductoCAD.CrearProducto(productoEN);
            return oid;
        }


        public void ModificarProducto(int p_Producto_OID, float p_precio, string p_nombre, int p_cantidad)
        {
            ProductoEN productoEN = null;

            //Initialized ProductoEN
            productoEN = new ProductoEN();
            productoEN.IdProducto = p_Producto_OID;
            productoEN.Precio = p_precio;
            productoEN.Nombre = p_nombre;
            productoEN.Cantidad = p_cantidad;
            //Call to ProductoCAD

            _IProductoCAD.ModificarProducto(productoEN);
        }

        public void BorrarProducto(int idProducto)
        {
            _IProductoCAD.BorrarProducto(idProducto);
        }

        public System.Collections.Generic.IList<ProductoEN> DameTodosLosProductos(int first, int size)
        {
            System.Collections.Generic.IList<ProductoEN> list = null;

            list = _IProductoCAD.DameTodosLosProductos(first, size);
            return list;
        }
        public System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> DamePorCategoría(string p_categoria)
        {
            return _IProductoCAD.DamePorCategoría(p_categoria);
        }
        public System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> DamePorNombre(string p_nombre)
        {
            return _IProductoCAD.DamePorNombre(p_nombre);
        }
    }

}
