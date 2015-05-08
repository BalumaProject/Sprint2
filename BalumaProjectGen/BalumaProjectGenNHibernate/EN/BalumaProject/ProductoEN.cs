
using System;
using System.Collections.Generic;

namespace BalumaProjectGenNHibernate.EN.BalumaProject
{
    public partial class ProductoEN
    {
        private int idProducto;
        private float precio;
        private AdministradorEN administrador;
        private IList<CategoriaEN> categoria;
        private IList<LineaPedidoEN> lineaPedido;
        private IList<CarritoEN> carrito;

        public virtual int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public virtual float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public virtual AdministradorEN Administrador
        {
            get { return administrador; }
            set { administrador = value; }
        }

        public virtual IList<CategoriaEN> Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public virtual IList<LineaPedidoEN> LineaPedido
        {
            get { return lineaPedido; }
            set { lineaPedido = value; }
        }

        public virtual IList<CarritoEN> Carrito
        {
            get { return carrito; }
            set { carrito = value; }
        }

        public ProductoEN()
        {
            categoria = new List<CategoriaEN>();
            carrito = new List<CarritoEN>();
        }

        public ProductoEN(int idProducto, float precio, AdministradorEN administrador, 
            IList<CategoriaEN> categoria, IList<LineaPedidoEN> lineaPedido, IList<CarritoEN> carrito)
        {
            this.init(idProducto, precio, administrador, categoria, lineaPedido, carrito);
        }

        public ProductoEN(ProductoEN producto)
        {
            this.init(producto.IdProducto, producto.Precio, producto.Administrador, 
                producto.Categoria, producto.LineaPedido, producto.Carrito);
        }

        private void init(int idProducto, float precio, AdministradorEN administrador, 
            IList<CategoriaEN> categoria, IList<LineaPedidoEN> lineaPedido, IList<CarritoEN> carrito)
        {
            this.IdProducto = idProducto;
            this.Precio = precio;
            this.Administrador = administrador;
            this.Categoria = categoria;
            this.LineaPedido = lineaPedido;
            this.Carrito = carrito;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            ProductoEN t = obj as ProductoEN;
            if (t == null)
                return false;
            if (IdProducto.Equals(t.IdProducto))
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;

            hash += this.IdProducto.GetHashCode();
            return hash;
        }
    }
}
