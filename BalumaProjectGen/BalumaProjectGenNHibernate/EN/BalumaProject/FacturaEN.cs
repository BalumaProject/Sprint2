
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





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual string HTML {
        get { return hTML; } set { hTML = value;  }
}





public FacturaEN()
{
}



public FacturaEN(int id, string hTML)
{
        this.init (id, hTML);
}


public FacturaEN(FacturaEN factura)
{
        this.init (factura.Id, factura.HTML);
}

private void init (int id, string hTML)
{
        this.Id = id;


        this.HTML = hTML;
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
