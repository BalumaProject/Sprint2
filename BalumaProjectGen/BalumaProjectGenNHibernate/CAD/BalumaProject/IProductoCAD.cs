
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


System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> DamePorCategoria (string p_categoria);


System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> DamePorNombre (string p_nombre);


System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> DamePorPrecio (float p_precio);


System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> DamePorCategoriayPrecio (string p_categoria, float p_precio);
}
}
