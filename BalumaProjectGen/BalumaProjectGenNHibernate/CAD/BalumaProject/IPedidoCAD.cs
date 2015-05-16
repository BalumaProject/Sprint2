
using System;
using BalumaProjectGenNHibernate.EN.BalumaProject;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial interface IPedidoCAD
{
PedidoEN ReadOIDDefault (int idPedido);

int CrearPedido (PedidoEN pedido);

void ModificarPedido (PedidoEN pedido);


void BorrarPedido (int idPedido);


void AnyadirLinea (int p_Pedido_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs);

void BorrarLinea (int p_Pedido_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs);


System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN> ObtenerPorCliente (string p_cliente);
}
}
