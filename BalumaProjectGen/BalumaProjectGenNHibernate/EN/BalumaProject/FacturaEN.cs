
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

private string hTML;

/**
 *
 */

private System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN> pedido;





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual string HTML {
        get { return hTML; } set { hTML = value;  }
}


public virtual System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN> Pedido {
        get { return pedido; } set { pedido = value;  }
}





public FacturaEN()
{
        pedido = new System.Collections.Generic.List<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN>();
}



public FacturaEN(int id, string hTML, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN> pedido)
{
        this.init (id, hTML, pedido);
}


public FacturaEN(FacturaEN factura)
{
        this.init (factura.Id, factura.HTML, factura.Pedido);
}

private void init (int id, string hTML, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN> pedido)
{
        this.Id = id;


        this.HTML = hTML;

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
