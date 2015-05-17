
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
public float CalcularPrecioTotal (System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> pedido)
{
        /*PROTECTED REGION ID(BalumaProjectGenNHibernate.CEN.BalumaProject_Factura_calcularPrecioTotal) ENABLED START*/

        // Write here your custom code...

        float suma = 0.0f;
        float precio = 0.0f;

        foreach (ProductoEN prod in pedido) {
                precio = prod.Precio;
                suma += precio;
        }

        return suma;
        /*PROTECTED REGION END*/
}
}
}
