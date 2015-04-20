

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

public int CrearCarrito (int p_previsualizar, string p_cliente)
{
        CarritoEN carritoEN = null;
        int oid;

        //Initialized CarritoEN
        carritoEN = new CarritoEN ();

        if (p_previsualizar != -1) {
                carritoEN.Previsualizar = new BalumaProjectGenNHibernate.EN.BalumaProject.PrevisualizarEN ();
                carritoEN.Previsualizar.Id = p_previsualizar;
        }


        if (p_cliente != null) {
                carritoEN.Cliente = new BalumaProjectGenNHibernate.EN.BalumaProject.ClienteEN ();
                carritoEN.Cliente.NIF = p_cliente;
        }

        //Call to CarritoCAD

        oid = _ICarritoCAD.CrearCarrito (carritoEN);
        return oid;
}
}
}
