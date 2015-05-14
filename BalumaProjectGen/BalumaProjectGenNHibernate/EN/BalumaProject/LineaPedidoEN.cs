
using System;

namespace BalumaProjectGenNHibernate.EN.BalumaProject
{
public partial class LineaPedidoEN
{
/**
 *
 */

private BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN producto;

/**
 *
 */

private BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido;

/**
 *
 */

private int numero;





public virtual BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN Producto {
        get { return producto; } set { producto = value;  }
}


public virtual BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}


public virtual int Numero {
        get { return numero; } set { numero = value;  }
}





public LineaPedidoEN()
{
}



public LineaPedidoEN(int numero, BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN producto, BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido)
{
        this.init (numero, producto, pedido);
}


public LineaPedidoEN(LineaPedidoEN lineaPedido)
{
        this.init (lineaPedido.Numero, lineaPedido.Producto, lineaPedido.Pedido);
}

private void init (int numero, BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN producto, BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido)
{
        this.Numero = numero;


        this.Producto = producto;

        this.Pedido = pedido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LineaPedidoEN t = obj as LineaPedidoEN;
        if (t == null)
                return false;
        if (Numero.Equals (t.Numero))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Numero.GetHashCode ();
        return hash;
}
}
}
