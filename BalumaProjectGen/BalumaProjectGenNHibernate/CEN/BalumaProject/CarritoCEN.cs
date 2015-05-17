

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
private ICarritoCAD _ICarritoCAD;

public CarritoCEN()
{
        this._ICarritoCAD = new CarritoCAD ();
}

public CarritoCEN(ICarritoCAD _ICarritoCAD)
{
        this._ICarritoCAD = _ICarritoCAD;
}

public ICarritoCAD get_ICarritoCAD ()
{
        return this._ICarritoCAD;
}

public int CrearCarrito (int p_cantidad)
{
        CarritoEN carritoEN = null;
        int oid;

        //Initialized CarritoEN
        carritoEN = new CarritoEN ();
        carritoEN.Cantidad = p_cantidad;

        //Call to CarritoCAD

        oid = _ICarritoCAD.CrearCarrito (carritoEN);
        return oid;
}

public void BorrarCarrito (int idCarrito)
{
        _ICarritoCAD.BorrarCarrito (idCarrito);
}

public void ModificarCarrito (int p_Carrito_OID, int p_cantidad)
{
        CarritoEN carritoEN = null;

        //Initialized CarritoEN
        carritoEN = new CarritoEN ();
        carritoEN.IdCarrito = p_Carrito_OID;
        carritoEN.Cantidad = p_cantidad;
        //Call to CarritoCAD

        _ICarritoCAD.ModificarCarrito (carritoEN);
}

public CarritoEN DamePorOID (int idCarrito)
{
        CarritoEN carritoEN = null;

        carritoEN = _ICarritoCAD.DamePorOID (idCarrito);
        return carritoEN;
}
}
}
