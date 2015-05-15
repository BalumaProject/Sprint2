
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
public partial class PrevisualizarCAD : BasicCAD, IPrevisualizarCAD
{
public PrevisualizarCAD() : base ()
{
}

public PrevisualizarCAD(ISession sessionAux) : base (sessionAux)
{
}



public PrevisualizarEN ReadOIDDefault (int id)
{
        PrevisualizarEN previsualizarEN = null;

        try
        {
                SessionInitializeTransaction ();
                previsualizarEN = (PrevisualizarEN)session.Get (typeof(PrevisualizarEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in PrevisualizarCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return previsualizarEN;
}


public int CrearFactura (PrevisualizarEN previsualizar)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (previsualizar);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in PrevisualizarCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return previsualizar.Id;
}
}
}
