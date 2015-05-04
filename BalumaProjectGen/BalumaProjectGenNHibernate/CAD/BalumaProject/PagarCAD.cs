
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
public partial class PagarCAD : BasicCAD, IPagarCAD
{
public PagarCAD() : base ()
{
}

public PagarCAD(ISession sessionAux) : base (sessionAux)
{
}



public PagarEN ReadOIDDefault (int id)
{
        PagarEN pagarEN = null;

        try
        {
                SessionInitializeTransaction ();
                pagarEN = (PagarEN)session.Get (typeof(PagarEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in PagarCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pagarEN;
}


public int Crear (PagarEN pagar)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (pagar);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in PagarCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pagar.Id;
}
}
}
