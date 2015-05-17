
using System;
using BalumaProjectGenNHibernate.EN.BalumaProject;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial interface ICarritoCAD
{
CarritoEN ReadOIDDefault (int idCarrito);

int CrearCarrito (CarritoEN carrito);




void BorrarCarrito (int idCarrito);


void ModificarCarrito (CarritoEN carrito);


CarritoEN DamePorOID (int idCarrito);
}
}
