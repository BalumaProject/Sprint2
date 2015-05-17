
using System;

namespace BalumaProjectGenNHibernate.EN.BalumaProject
{
public partial class FacturaEN
{
/**
 *
 */

private int id;

/**
 *
 */

private System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN> pedido;





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN> Pedido {
        get { return pedido; } set { pedido = value;  }
}





public FacturaEN()
{
        pedido = new System.Collections.Generic.List<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN>();
}



public FacturaEN(int id, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN> pedido)
{
        this.init (id, pedido);
}


public FacturaEN(FacturaEN factura)
{
        this.init (factura.Id, factura.Pedido);
}

private void init (int id, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN> pedido)
{
        this.Id = id;


        this.Pedido = pedido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        FacturaEN t = obj as FacturaEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
