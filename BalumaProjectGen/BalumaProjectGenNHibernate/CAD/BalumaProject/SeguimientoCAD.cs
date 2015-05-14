
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
public partial class SeguimientoCAD : BasicCAD, ISeguimientoCAD
{
public SeguimientoCAD() : base ()
{
}

public SeguimientoCAD(ISession sessionAux) : base (sessionAux)
{
}



public SeguimientoEN ReadOIDDefault (string idSeguimiento)
{
        SeguimientoEN seguimientoEN = null;

        try
        {
                SessionInitializeTransaction ();
                seguimientoEN = (SeguimientoEN)session.Get (typeof(SeguimientoEN), idSeguimiento);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in SeguimientoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return seguimientoEN;
}


public string CrearSeguimiento (SeguimientoEN seguimiento)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (seguimiento);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in SeguimientoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return seguimiento.IdSeguimiento;
}
}
}
