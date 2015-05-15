
using System;

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





public virtual System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> Producto {
        get { return producto; } set { producto = value;  }
}


public virtual BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}





public AdministradorEN() : base ()
{
        producto = new System.Collections.Generic.List<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN>();
}



public AdministradorEN(string nIF, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> producto, BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido, string apellidos, string password, string username, BalumaProjectGenNHibernate.EN.BalumaProject.ValidarEN validar, string nombre)
{
        this.init (nIF, producto, pedido, apellidos, password, username, validar, nombre);
}


public AdministradorEN(AdministradorEN administrador)
{
        this.init (administrador.NIF, administrador.Producto, administrador.Pedido, administrador.Apellidos, administrador.Password, administrador.Username, administrador.Validar, administrador.Nombre);
}

private void init (string nIF, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> producto, BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido, string apellidos, string password, string username, BalumaProjectGenNHibernate.EN.BalumaProject.ValidarEN validar, string nombre)
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

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AdministradorEN t = obj as AdministradorEN;
        if (t == null)
                return false;
        if (NIF.Equals (t.NIF))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.NIF.GetHashCode ();
        return hash;
}
}
}
