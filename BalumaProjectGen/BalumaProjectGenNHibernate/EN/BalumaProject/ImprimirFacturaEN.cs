
using System;

namespace BalumaProjectGenNHibernate.EN.BalumaProject
{
public partial class ImprimirFacturaEN                  :                           BalumaProjectGenNHibernate.EN.BalumaProject.FacturaEN


{
/**
 *
 */

private BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido;

/**
 *
 */

private System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.FacturaEN> factura;





public virtual BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}


public virtual System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.FacturaEN> Factura {
        get { return factura; } set { factura = value;  }
}





public ImprimirFacturaEN() : base ()
{
        factura = new System.Collections.Generic.List<BalumaProjectGenNHibernate.EN.BalumaProject.FacturaEN>();
}



public ImprimirFacturaEN(int id, BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.FacturaEN> factura, string hTML, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ImprimirFacturaEN> imprimirFactura)
{
        this.init (id, pedido, factura, hTML, imprimirFactura);
}


public ImprimirFacturaEN(ImprimirFacturaEN imprimirFactura)
{
        this.init (imprimirFactura.Id, imprimirFactura.Pedido, imprimirFactura.Factura, imprimirFactura.HTML, imprimirFactura.ImprimirFactura);
}

private void init (int id, BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.FacturaEN> factura, string hTML, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ImprimirFacturaEN> imprimirFactura)
{
        this.Id = id;


        this.Pedido = pedido;

        this.Factura = factura;

        this.HTML = hTML;

        this.ImprimirFactura = imprimirFactura;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ImprimirFacturaEN t = obj as ImprimirFacturaEN;
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
