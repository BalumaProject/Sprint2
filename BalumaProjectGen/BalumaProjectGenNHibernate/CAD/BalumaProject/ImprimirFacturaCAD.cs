
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
public partial class ImprimirFacturaCAD : BasicCAD, IImprimirFacturaCAD
{
public ImprimirFacturaCAD() : base ()
{
}

public ImprimirFacturaCAD(ISession sessionAux) : base (sessionAux)
{
}



public ImprimirFacturaEN ReadOIDDefault (int id)
{
        ImprimirFacturaEN imprimirFacturaEN = null;

        try
        {
                SessionInitializeTransaction ();
                imprimirFacturaEN = (ImprimirFacturaEN)session.Get (typeof(ImprimirFacturaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in ImprimirFacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return imprimirFacturaEN;
}


public int CrearFactura (ImprimirFacturaEN imprimirFactura)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (imprimirFactura);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in ImprimirFacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return imprimirFactura.Id;
}
}
}
