
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
public partial class CarritoCEN
{
   
public void AnyadirProducto (int p_oid, BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN producto)
{
        /*PROTECTED REGION ID(BalumaProjectGenNHibernate.CEN.BalumaProject_Carrito_anyadirProducto) ENABLED START*/

        // Write here your custom code...
    
    int cantidad = carrito.Cantidad; 
        cantidad++;
        this.ModificarCarrito (1, cantidad);



        /*PROTECTED REGION END*/
}
}
}
