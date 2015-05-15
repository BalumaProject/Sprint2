
using System;
using BalumaProjectGenNHibernate.EN.BalumaProject;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial interface ILineaPedidoCAD
{
LineaPedidoEN ReadOIDDefault (int numero);

int CrearLinea (LineaPedidoEN lineaPedido);

void ModificarLinea (LineaPedidoEN lineaPedido);
}
}
