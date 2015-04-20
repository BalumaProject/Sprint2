
using System;

namespace BalumaProjectGenNHibernate.EN.BalumaProject
{
public partial class PagarEN
{
/**
 *
 */

private BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido;

/**
 *
 */

private int id;





public virtual BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}


public virtual int Id {
        get { return id; } set { id = value;  }
}





public PagarEN()
{
}



public PagarEN(int id, BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido)
{
        this.init (id, pedido);
}


public PagarEN(PagarEN pagar)
{
        this.init (pagar.Id, pagar.Pedido);
}

private void init (int id, BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido)
{
        this.Id = id;


        this.Pedido = pedido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PagarEN t = obj as PagarEN;
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
