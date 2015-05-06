
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

private System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ImprimirFacturaEN> imprimirFactura;





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual string HTML {
        get { return hTML; } set { hTML = value;  }
}


public virtual System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ImprimirFacturaEN> ImprimirFactura {
        get { return imprimirFactura; } set { imprimirFactura = value;  }
}





public FacturaEN()
{
        imprimirFactura = new System.Collections.Generic.List<BalumaProjectGenNHibernate.EN.BalumaProject.ImprimirFacturaEN>();
}



public FacturaEN(int id, string hTML, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ImprimirFacturaEN> imprimirFactura)
{
        this.init (id, hTML, imprimirFactura);
}


public FacturaEN(FacturaEN factura)
{
        this.init (factura.Id, factura.HTML, factura.ImprimirFactura);
}

private void init (int id, string hTML, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ImprimirFacturaEN> imprimirFactura)
{
        this.Id = id;


        this.HTML = hTML;

        this.ImprimirFactura = imprimirFactura;
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
