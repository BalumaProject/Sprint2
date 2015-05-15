
using System;
using BalumaProjectGenNHibernate.EN.BalumaProject;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial interface IPrevisualizarCAD
{
PrevisualizarEN ReadOIDDefault (int id);


int CrearFactura (PrevisualizarEN previsualizar);
}
}
