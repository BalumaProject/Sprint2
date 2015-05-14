
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
public partial class ValidarCAD : BasicCAD, IValidarCAD
{
public ValidarCAD() : base ()
{
}

public ValidarCAD(ISession sessionAux) : base (sessionAux)
{
}



public ValidarEN ReadOIDDefault (int id)
{
        ValidarEN validarEN = null;

        try
        {
                SessionInitializeTransaction ();
                validarEN = (ValidarEN)session.Get (typeof(ValidarEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in ValidarCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return validarEN;
}


public int Crear (ValidarEN validar)
{
        try
        {
                SessionInitializeTransaction ();
                if (validar.Usuario != null) {
                        validar.Usuario = (BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN)session.Load (typeof(BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN), validar.Usuario.NIF);

                        validar.Usuario.Validar = validar;
                }

                session.Save (validar);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in ValidarCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return validar.Id;
}
}
}
