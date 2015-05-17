
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
public partial class FacturaCEN
{
public float CalcularPrecioTotal (int p_oid, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> pedido)
{

    float suma = 0.0f;

    foreach (ProductoEN producto in pedido)
    {
        suma += producto.Precio;
    }

    return suma;
}
}
}
