
using System;

namespace BalumaProjectGenNHibernate.EN.BalumaProject
{
public partial class SeguimientoClienteEN               :                           BalumaProjectGenNHibernate.EN.BalumaProject.SeguimientoEN


{
/**
 *
 */

private System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN> pedido;





public virtual System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN> Pedido {
        get { return pedido; } set { pedido = value;  }
}





public SeguimientoClienteEN() : base ()
{
        pedido = new System.Collections.Generic.List<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN>();
}



public SeguimientoClienteEN(string idSeguimiento, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN> pedido, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.SeguimientoAdminEN> seguimientoAdmin)
{
        this.init (idSeguimiento, pedido, seguimientoAdmin);
}


public SeguimientoClienteEN(SeguimientoClienteEN seguimientoCliente)
{
        this.init (seguimientoCliente.IdSeguimiento, seguimientoCliente.Pedido, seguimientoCliente.SeguimientoAdmin);
}

private void init (string idSeguimiento, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN> pedido, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.SeguimientoAdminEN> seguimientoAdmin)
{
        this.IdSeguimiento = idSeguimiento;


        this.Pedido = pedido;

        this.SeguimientoAdmin = seguimientoAdmin;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        SeguimientoClienteEN t = obj as SeguimientoClienteEN;
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
