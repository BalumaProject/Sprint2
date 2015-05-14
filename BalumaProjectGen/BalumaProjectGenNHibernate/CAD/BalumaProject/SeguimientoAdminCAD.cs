
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
public partial class SeguimientoAdminCAD : BasicCAD, ISeguimientoAdminCAD
{
public SeguimientoAdminCAD() : base ()
{
}

public SeguimientoAdminCAD(ISession sessionAux) : base (sessionAux)
{
}



public SeguimientoAdminEN ReadOIDDefault (string idSeguimiento)
{
        SeguimientoAdminEN seguimientoAdminEN = null;

        try
        {
                SessionInitializeTransaction ();
                seguimientoAdminEN = (SeguimientoAdminEN)session.Get (typeof(SeguimientoAdminEN), idSeguimiento);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in SeguimientoAdminCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return seguimientoAdminEN;
}


public string CrearSegAdmin (SeguimientoAdminEN seguimientoAdmin)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (seguimientoAdmin);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in SeguimientoAdminCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return seguimientoAdmin.IdSeguimiento;
}
}
}
