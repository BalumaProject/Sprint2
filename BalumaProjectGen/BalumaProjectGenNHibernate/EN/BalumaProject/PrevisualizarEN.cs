
using System;

namespace BalumaProjectGenNHibernate.EN.BalumaProject
{
public partial class PrevisualizarEN                    :                           BalumaProjectGenNHibernate.EN.BalumaProject.FacturaEN


{
/**
 *
 */

private BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN carrito;





public virtual BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN Carrito {
        get { return carrito; } set { carrito = value;  }
}





public PrevisualizarEN() : base ()
{
}



public PrevisualizarEN(int id, BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN carrito, string hTML, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ImprimirFacturaEN> imprimirFactura)
{
        this.init (id, carrito, hTML, imprimirFactura);
}


public PrevisualizarEN(PrevisualizarEN previsualizar)
{
        this.init (previsualizar.Id, previsualizar.Carrito, previsualizar.HTML, previsualizar.ImprimirFactura);
}

private void init (int id, BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN carrito, string hTML, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ImprimirFacturaEN> imprimirFactura)
{
        this.Id = id;


        this.Carrito = carrito;

        this.HTML = hTML;

        this.ImprimirFactura = imprimirFactura;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PrevisualizarEN t = obj as PrevisualizarEN;
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
