
using System;

namespace BalumaProjectGenNHibernate.EN.BalumaProject
{
public partial class ImprimirFacturaEN                  :                           BalumaProjectGenNHibernate.EN.BalumaProject.FacturaEN


{
/**
 *
 */

private BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido;





public virtual BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}





public ImprimirFacturaEN() : base ()
{
}



public ImprimirFacturaEN(int id, BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido, string hTML)
{
        this.init (id, pedido, hTML);
}


public ImprimirFacturaEN(ImprimirFacturaEN imprimirFactura)
{
        this.init (imprimirFactura.Id, imprimirFactura.Pedido, imprimirFactura.HTML);
}

private void init (int id, BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido, string hTML)
{
        this.Id = id;


        this.Pedido = pedido;

        this.HTML = hTML;
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
