
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
public partial class SeguimientoClienteCAD : BasicCAD, ISeguimientoClienteCAD
{
public SeguimientoClienteCAD() : base ()
{
}

public SeguimientoClienteCAD(ISession sessionAux) : base (sessionAux)
{
}



public SeguimientoClienteEN ReadOIDDefault (string idSeguimiento)
{
        SeguimientoClienteEN seguimientoClienteEN = null;

        try
        {
                SessionInitializeTransaction ();
                seguimientoClienteEN = (SeguimientoClienteEN)session.Get (typeof(SeguimientoClienteEN), idSeguimiento);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in SeguimientoClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return seguimientoClienteEN;
}


public string CrearSegCliente (SeguimientoClienteEN seguimientoCliente)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (seguimientoCliente);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in SeguimientoClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return seguimientoCliente.IdSeguimiento;
}
}
}
