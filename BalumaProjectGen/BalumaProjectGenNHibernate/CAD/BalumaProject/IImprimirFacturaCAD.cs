
using System;
using BalumaProjectGenNHibernate.EN.BalumaProject;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial interface IImprimirFacturaCAD
{
ImprimirFacturaEN ReadOIDDefault (int id);


int CrearFactura (ImprimirFacturaEN imprimirFactura);
}
}
