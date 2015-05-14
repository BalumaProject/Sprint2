
using System;

namespace BalumaProjectGenNHibernate.EN.BalumaProject
{
public partial class SeguimientoAdminEN                 :                           BalumaProjectGenNHibernate.EN.BalumaProject.SeguimientoEN


{
/**
 *
 */

private System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.SeguimientoEN> seguimiento;





public virtual System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.SeguimientoEN> Seguimiento {
        get { return seguimiento; } set { seguimiento = value;  }
}





public SeguimientoAdminEN() : base ()
{
        seguimiento = new System.Collections.Generic.List<BalumaProjectGenNHibernate.EN.BalumaProject.SeguimientoEN>();
}



public SeguimientoAdminEN(string idSeguimiento, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.SeguimientoEN> seguimiento, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.SeguimientoAdminEN> seguimientoAdmin)
{
        this.init (idSeguimiento, seguimiento, seguimientoAdmin);
}


public SeguimientoAdminEN(SeguimientoAdminEN seguimientoAdmin)
{
        this.init (seguimientoAdmin.IdSeguimiento, seguimientoAdmin.Seguimiento, seguimientoAdmin.SeguimientoAdmin);
}

private void init (string idSeguimiento, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.SeguimientoEN> seguimiento, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.SeguimientoAdminEN> seguimientoAdmin)
{
        this.IdSeguimiento = idSeguimiento;


        this.Seguimiento = seguimiento;

        this.SeguimientoAdmin = seguimientoAdmin;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        SeguimientoAdminEN t = obj as SeguimientoAdminEN;
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
