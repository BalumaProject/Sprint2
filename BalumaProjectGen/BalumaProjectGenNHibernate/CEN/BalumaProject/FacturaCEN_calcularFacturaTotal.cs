
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
public float CalcularFacturaTotal (int p_oid, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> pedido)
{
        /*PROTECTED REGION ID(BalumaProjectGenNHibernate.CEN.BalumaProject_Factura_calcularFacturaTotal) ENABLED START*/

        float precio_total = 0;

        foreach (ProductoEN prod in pedido) {
                precio_total = prod.Precio + precio_total;
        }
        /*PROTECTED REGION END*/

        return precio_total;
}
}
}
