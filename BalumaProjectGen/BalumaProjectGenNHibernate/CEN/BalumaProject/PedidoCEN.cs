

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using BalumaProjectGenNHibernate.EN.BalumaProject;
using BalumaProjectGenNHibernate.CAD.BalumaProject;

namespace BalumaProjectGenNHibernate.CEN.BalumaProject
{
public partial class PedidoCEN
{
private IPedidoCAD _IPedidoCAD;

public PedidoCEN()
{
        this._IPedidoCAD = new PedidoCAD ();
}

public PedidoCEN(IPedidoCAD _IPedidoCAD)
{
        this._IPedidoCAD = _IPedidoCAD;
}

public IPedidoCAD get_IPedidoCAD ()
{
        return this._IPedidoCAD;
}

public int CrearPedido (int p_idPedido, Nullable<DateTime> p_fecha, BalumaProjectGenNHibernate.Enumerated.BalumaProject.EstadoPedidoEnum p_estado, BalumaProjectGenNHibernate.Enumerated.BalumaProject.TipoPagoEnum p_tipoPago, int p_pagar, string p_administrador, int p_imprimirFactura, string p_cliente)
{
        PedidoEN pedidoEN = null;
        int oid;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.IdPedido = p_idPedido;

        pedidoEN.Fecha = p_fecha;

        pedidoEN.Estado = p_estado;

        pedidoEN.TipoPago = p_tipoPago;


        if (p_pagar != -1) {
                pedidoEN.Pagar = new BalumaProjectGenNHibernate.EN.BalumaProject.PagarEN ();
                pedidoEN.Pagar.Id = p_pagar;
        }


        if (p_administrador != null) {
                pedidoEN.Administrador = new BalumaProjectGenNHibernate.EN.BalumaProject.AdministradorEN ();
                pedidoEN.Administrador.NIF = p_administrador;
        }


        if (p_imprimirFactura != -1) {
                pedidoEN.ImprimirFactura = new BalumaProjectGenNHibernate.EN.BalumaProject.ImprimirFacturaEN ();
                pedidoEN.ImprimirFactura.Id = p_imprimirFactura;
        }


        if (p_cliente != null) {
                pedidoEN.Cliente = new BalumaProjectGenNHibernate.EN.BalumaProject.ClienteEN ();
                pedidoEN.Cliente.NIF = p_cliente;
        }

        //Call to PedidoCAD

        oid = _IPedidoCAD.CrearPedido (pedidoEN);
        return oid;
}

public void ModificarPedido (int p_Pedido_OID, Nullable<DateTime> p_fecha, BalumaProjectGenNHibernate.Enumerated.BalumaProject.EstadoPedidoEnum p_estado, BalumaProjectGenNHibernate.Enumerated.BalumaProject.TipoPagoEnum p_tipoPago)
{
        PedidoEN pedidoEN = null;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.IdPedido = p_Pedido_OID;
        pedidoEN.Fecha = p_fecha;
        pedidoEN.Estado = p_estado;
        pedidoEN.TipoPago = p_tipoPago;
        //Call to PedidoCAD

        _IPedidoCAD.ModificarPedido (pedidoEN);
}

public void BorrarPedido (int idPedido)
{
        _IPedidoCAD.BorrarPedido (idPedido);
}

public void AnyadirLinea (int p_Pedido_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs)
{
        //Call to PedidoCAD

        _IPedidoCAD.AnyadirLinea (p_Pedido_OID, p_lineaPedido_OIDs);
}
public void BorrarLinea (int p_Pedido_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs)
{
        //Call to PedidoCAD

        _IPedidoCAD.BorrarLinea (p_Pedido_OID, p_lineaPedido_OIDs);
}
}
}
