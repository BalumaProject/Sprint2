
using System;

namespace BalumaProjectGenNHibernate.EN.BalumaProject
{
public partial class PedidoEN
{
/**
 *
 */

private int idPedido;

/**
 *
 */

private Nullable<DateTime> fecha;

/**
 *
 */

private BalumaProjectGenNHibernate.Enumerated.BalumaProject.EstadoPedidoEnum estado;

/**
 *
 */

private BalumaProjectGenNHibernate.Enumerated.BalumaProject.TipoPagoEnum tipoPago;

/**
 *
 */

private BalumaProjectGenNHibernate.EN.BalumaProject.AdministradorEN administrador;

/**
 *
 */

private System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN> lineaPedido;

/**
 *
 */

private BalumaProjectGenNHibernate.EN.BalumaProject.ClienteEN cliente;





public virtual int IdPedido {
        get { return idPedido; } set { idPedido = value;  }
}


public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}


public virtual BalumaProjectGenNHibernate.Enumerated.BalumaProject.EstadoPedidoEnum Estado {
        get { return estado; } set { estado = value;  }
}


public virtual BalumaProjectGenNHibernate.Enumerated.BalumaProject.TipoPagoEnum TipoPago {
        get { return tipoPago; } set { tipoPago = value;  }
}


public virtual BalumaProjectGenNHibernate.EN.BalumaProject.AdministradorEN Administrador {
        get { return administrador; } set { administrador = value;  }
}


public virtual System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN> LineaPedido {
        get { return lineaPedido; } set { lineaPedido = value;  }
}


public virtual BalumaProjectGenNHibernate.EN.BalumaProject.ClienteEN Cliente {
        get { return cliente; } set { cliente = value;  }
}





public PedidoEN()
{
        lineaPedido = new System.Collections.Generic.List<BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN>();
}



public PedidoEN(int idPedido, Nullable<DateTime> fecha, BalumaProjectGenNHibernate.Enumerated.BalumaProject.EstadoPedidoEnum estado, BalumaProjectGenNHibernate.Enumerated.BalumaProject.TipoPagoEnum tipoPago, BalumaProjectGenNHibernate.EN.BalumaProject.AdministradorEN administrador, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN> lineaPedido, BalumaProjectGenNHibernate.EN.BalumaProject.ClienteEN cliente)
{
        this.init (idPedido, fecha, estado, tipoPago, administrador, lineaPedido, cliente);
}


public PedidoEN(PedidoEN pedido)
{
        this.init (pedido.IdPedido, pedido.Fecha, pedido.Estado, pedido.TipoPago, pedido.Administrador, pedido.LineaPedido, pedido.Cliente);
}

private void init (int idPedido, Nullable<DateTime> fecha, BalumaProjectGenNHibernate.Enumerated.BalumaProject.EstadoPedidoEnum estado, BalumaProjectGenNHibernate.Enumerated.BalumaProject.TipoPagoEnum tipoPago, BalumaProjectGenNHibernate.EN.BalumaProject.AdministradorEN administrador, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN> lineaPedido, BalumaProjectGenNHibernate.EN.BalumaProject.ClienteEN cliente)
{
        this.IdPedido = idPedido;


        this.Fecha = fecha;

        this.Estado = estado;

        this.TipoPago = tipoPago;

        this.Administrador = administrador;

        this.LineaPedido = lineaPedido;

        this.Cliente = cliente;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PedidoEN t = obj as PedidoEN;
        if (t == null)
                return false;
        if (IdPedido.Equals (t.IdPedido))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdPedido.GetHashCode ();
        return hash;
}
}
}
