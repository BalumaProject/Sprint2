
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


System.Collections.Generic.IList<ProductoEN> DameTodosLosProductos (int first, int size);


System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> DamePorCategoría (string p_categoria);


System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> DamePorNombre (string p_nombre);
}
}
