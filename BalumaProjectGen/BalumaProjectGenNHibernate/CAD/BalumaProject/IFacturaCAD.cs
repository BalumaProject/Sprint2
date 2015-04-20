
using System;
using BalumaProjectGenNHibernate.EN.BalumaProject;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial interface IFacturaCAD
{
FacturaEN ReadOIDDefault (int id);

int CrearFactura (FacturaEN factura);
}
}
