
using System;

namespace BalumaProjectGenNHibernate.EN.BalumaProject
{
public partial class SeguimientoEN
{
/**
 *
 */

private string idSeguimiento;

/**
 *
 */

private System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.SeguimientoAdminEN> seguimientoAdmin;





public virtual string IdSeguimiento {
        get { return idSeguimiento; } set { idSeguimiento = value;  }
}


public virtual System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.SeguimientoAdminEN> SeguimientoAdmin {
        get { return seguimientoAdmin; } set { seguimientoAdmin = value;  }
}





public SeguimientoEN()
{
        seguimientoAdmin = new System.Collections.Generic.List<BalumaProjectGenNHibernate.EN.BalumaProject.SeguimientoAdminEN>();
}



public SeguimientoEN(string idSeguimiento, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.SeguimientoAdminEN> seguimientoAdmin)
{
        this.init (idSeguimiento, seguimientoAdmin);
}


public SeguimientoEN(SeguimientoEN seguimiento)
{
        this.init (seguimiento.IdSeguimiento, seguimiento.SeguimientoAdmin);
}

private void init (string idSeguimiento, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.SeguimientoAdminEN> seguimientoAdmin)
{
        this.IdSeguimiento = idSeguimiento;


        this.SeguimientoAdmin = seguimientoAdmin;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        SeguimientoEN t = obj as SeguimientoEN;
        if (t == null)
                return false;
        if (IdSeguimiento.Equals (t.IdSeguimiento))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdSeguimiento.GetHashCode ();
        return hash;
}
}
}
