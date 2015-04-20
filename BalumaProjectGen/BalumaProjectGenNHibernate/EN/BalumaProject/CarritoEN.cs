
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

private BalumaProjectGenNHibernate.EN.BalumaProject.ClienteEN cliente;

/**
 *
 */

private System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN> lineaPedido;

/**
 *
 */

private int idCarrito;





public virtual BalumaProjectGenNHibernate.EN.BalumaProject.PrevisualizarEN Previsualizar {
        get { return previsualizar; } set { previsualizar = value;  }
}


public virtual BalumaProjectGenNHibernate.EN.BalumaProject.ClienteEN Cliente {
        get { return cliente; } set { cliente = value;  }
}


public virtual System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN> LineaPedido {
        get { return lineaPedido; } set { lineaPedido = value;  }
}


public virtual int IdCarrito {
        get { return idCarrito; } set { idCarrito = value;  }
}





public CarritoEN()
{
        lineaPedido = new System.Collections.Generic.List<BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN>();
}



public CarritoEN(int idCarrito, BalumaProjectGenNHibernate.EN.BalumaProject.PrevisualizarEN previsualizar, BalumaProjectGenNHibernate.EN.BalumaProject.ClienteEN cliente, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN> lineaPedido)
{
        this.init (idCarrito, previsualizar, cliente, lineaPedido);
}


public CarritoEN(CarritoEN carrito)
{
        this.init (carrito.IdCarrito, carrito.Previsualizar, carrito.Cliente, carrito.LineaPedido);
}

private void init (int idCarrito, BalumaProjectGenNHibernate.EN.BalumaProject.PrevisualizarEN previsualizar, BalumaProjectGenNHibernate.EN.BalumaProject.ClienteEN cliente, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN> lineaPedido)
{
        this.IdCarrito = idCarrito;


        this.Previsualizar = previsualizar;

        this.Cliente = cliente;

        this.LineaPedido = lineaPedido;
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
