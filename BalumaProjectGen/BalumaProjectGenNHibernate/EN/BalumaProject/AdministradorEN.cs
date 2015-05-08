using System;
using System.Collections.Generic;

namespace BalumaProjectGenNHibernate.EN.BalumaProject
{
    public partial class AdministradorEN : UsuarioEN
    {
        private IList<ProductoEN> producto;
        private PedidoEN pedido;

        public virtual IList<ProductoEN> Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public virtual PedidoEN Pedido
        {
            get { return pedido; }
            set { pedido = value; }
        }

        public AdministradorEN() : base()
        {
            producto = new List<ProductoEN>();
        }

        public AdministradorEN(string nif, IList<ProductoEN> producto, PedidoEN pedido, string apellidos, string password, string username, ValidarEN validar, string nombre)
        {
            this.init(nif, producto, pedido, apellidos, password, username, validar, nombre);
        }

        public AdministradorEN(AdministradorEN administrador)
        {
            this.init(administrador.NIF, administrador.Producto, administrador.Pedido, administrador.Apellidos, administrador.Password, administrador.Username, administrador.Validar, administrador.Nombre);
        }

        private void init(string nIF, IList<ProductoEN> producto, PedidoEN pedido, string apellidos, string password, string username, ValidarEN validar, string nombre)
        {
            this.NIF = NIF;
            this.Producto = producto;
            this.Pedido = pedido;
            this.Apellidos = apellidos;
            this.Password = password;
            this.Username = username;
            this.Validar = validar;
            this.Nombre = nombre;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            AdministradorEN t = obj as AdministradorEN;
            if (t == null)
                return false;
            if (NIF.Equals(t.NIF))
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;

            hash += this.NIF.GetHashCode();
            return hash;
        }
    }
}
