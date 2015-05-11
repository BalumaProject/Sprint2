using System;
using System.Collections.Generic;

namespace BalumaProjectGenNHibernate.EN.BalumaProject
{

public partial class AdministradorEN                    :                           BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN


{
/**
 *
 */

private System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> producto;

/**
 *
 */

private BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido;

/**
 *
 */

private System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN> usuario;





public virtual System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> Producto {
        get { return producto; } set { producto = value;  }
}


public virtual BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}


public virtual System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN> Usuario {
        get { return usuario; } set { usuario = value;  }
}





public AdministradorEN() : base ()
{
        producto = new System.Collections.Generic.List<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN>();
        usuario = new System.Collections.Generic.List<BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN>();
}



public AdministradorEN(string nIF, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> producto, BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN> usuario, string apellidos, string password, string username, BalumaProjectGenNHibernate.EN.BalumaProject.ValidarEN validar, string nombre, BalumaProjectGenNHibernate.EN.BalumaProject.AdministradorEN administrador)
{
        this.init (nIF, producto, pedido, usuario, apellidos, password, username, validar, nombre, administrador);
}


public AdministradorEN(AdministradorEN administrador)
{
        this.init (administrador.NIF, administrador.Producto, administrador.Pedido, administrador.Usuario, administrador.Apellidos, administrador.Password, administrador.Username, administrador.Validar, administrador.Nombre, administrador.Administrador);
}

private void init (string nIF, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> producto, BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN> usuario, string apellidos, string password, string username, BalumaProjectGenNHibernate.EN.BalumaProject.ValidarEN validar, string nombre, BalumaProjectGenNHibernate.EN.BalumaProject.AdministradorEN administrador)
{
        this.NIF = NIF;


        this.Producto = producto;

        this.Pedido = pedido;

        this.Usuario = usuario;

        this.Apellidos = apellidos;

        this.Password = password;

        this.Username = username;

        this.Validar = validar;

        this.Nombre = nombre;

        this.Administrador = administrador;
}

public override bool Equals (object obj)
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
