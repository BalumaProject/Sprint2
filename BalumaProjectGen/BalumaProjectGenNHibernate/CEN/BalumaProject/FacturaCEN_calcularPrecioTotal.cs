
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
        /*PROTECTED REGION ID(BalumaProjectGenNHibernate.CEN.BalumaProject_Factura_calcularPrecioTotal) ENABLED START*/

    float precio_total = 0.0f;

    foreach (ProductoEN producto in pedido)
    {
        precio_total = producto.Precio + precio_total;
    }

    return precio_total;


        /*PROTECTED REGION END*/
}
}
}
