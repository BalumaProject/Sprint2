
using System;

namespace BalumaProjectGenNHibernate.EN.BalumaProject
{
public partial class CarritoEN
{
/**
 *
 */

private BalumaProjectGenNHibernate.EN.BalumaProject.PrevisualizarEN previsualizar;

/**
 *
 */

private int idCarrito;

/**
 *
 */

private System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ClienteEN> cliente;

/**
 *
 */

private System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> producto;





public virtual BalumaProjectGenNHibernate.EN.BalumaProject.PrevisualizarEN Previsualizar {
        get { return previsualizar; } set { previsualizar = value;  }
}


public virtual int IdCarrito {
        get { return idCarrito; } set { idCarrito = value;  }
}


public virtual System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ClienteEN> Cliente {
        get { return cliente; } set { cliente = value;  }
}


public virtual System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> Producto {
        get { return producto; } set { producto = value;  }
}





public CarritoEN()
{
        cliente = new System.Collections.Generic.List<BalumaProjectGenNHibernate.EN.BalumaProject.ClienteEN>();
        producto = new System.Collections.Generic.List<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN>();
}



public CarritoEN(int idCarrito, BalumaProjectGenNHibernate.EN.BalumaProject.PrevisualizarEN previsualizar, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ClienteEN> cliente, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> producto)
{
        this.init (idCarrito, previsualizar, cliente, producto);
}


public CarritoEN(CarritoEN carrito)
{
        this.init (carrito.IdCarrito, carrito.Previsualizar, carrito.Cliente, carrito.Producto);
}

private void init (int idCarrito, BalumaProjectGenNHibernate.EN.BalumaProject.PrevisualizarEN previsualizar, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ClienteEN> cliente, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> producto)
{
        this.IdCarrito = idCarrito;


        this.Previsualizar = previsualizar;

        this.Cliente = cliente;

        this.Producto = producto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CarritoEN t = obj as CarritoEN;
        if (t == null)
                return false;
        if (IdCarrito.Equals (t.IdCarrito))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdCarrito.GetHashCode ();
        return hash;
}
}
}
