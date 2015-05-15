
using System;
using BalumaProjectGenNHibernate.EN.BalumaProject;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial interface ICarritoCAD
{
CarritoEN ReadOIDDefault (int idCarrito);

int CrearCarrito (CarritoEN carrito);
}
}
