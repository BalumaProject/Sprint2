
using System;
using BalumaProjectGenNHibernate.EN.BalumaProject;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial interface IProductoCAD
{
ProductoEN ReadOIDDefault (int idProducto);

int CrearProducto (ProductoEN producto);

void ModificarProducto (ProductoEN producto);


void BorrarProducto (int idProducto);
}
}
