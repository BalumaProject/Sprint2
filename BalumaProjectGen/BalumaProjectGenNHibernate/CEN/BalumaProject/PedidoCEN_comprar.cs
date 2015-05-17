
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
public void Comprar (int p_oid, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> productos)
{
    LineaPedidoCEN licen = new LineaPedidoCEN();
    int numLinea = 0;
    foreach (ProductoEN prod in productos)
    {
        licen.CrearLinea(prod.IdProducto, p_oid);
        numLinea++;
    }
}
}
}
