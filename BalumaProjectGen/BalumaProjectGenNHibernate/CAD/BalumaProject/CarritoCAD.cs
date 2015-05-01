
using System;
using System.Text;
using BalumaProjectGenNHibernate.CEN.BalumaProject;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using BalumaProjectGenNHibernate.EN.BalumaProject;
using BalumaProjectGenNHibernate.Exceptions;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial class CarritoCAD : BasicCAD, ICarritoCAD
{
public CarritoCAD() : base ()
{
}

public CarritoCAD(ISession sessionAux) : base (sessionAux)
{
}



public CarritoEN ReadOIDDefault (int idCarrito)
{
        CarritoEN carritoEN = null;

        try
        {
                SessionInitializeTransaction ();
                carritoEN = (CarritoEN)session.Get (typeof(CarritoEN), idCarrito);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in CarritoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return carritoEN;
}


public int CrearCarrito (CarritoEN carrito)
{
        try
        {
                SessionInitializeTransaction ();
                if (carrito.Previsualizar != null) {
                        carrito.Previsualizar = (BalumaProjectGenNHibernate.EN.BalumaProject.PrevisualizarEN)session.Load (typeof(BalumaProjectGenNHibernate.EN.BalumaProject.PrevisualizarEN), carrito.Previsualizar.Id);

                        carrito.Previsualizar.Carrito = carrito;
                }
                if (carrito.Cliente != null) {
                        carrito.Cliente = (BalumaProjectGenNHibernate.EN.BalumaProject.ClienteEN)session.Load (typeof(BalumaProjectGenNHibernate.EN.BalumaProject.ClienteEN), carrito.Cliente.NIF);

                        carrito.Cliente.Carrito = carrito;
                }

                session.Save (carrito);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in CarritoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return carrito.IdCarrito;
}
}
}
