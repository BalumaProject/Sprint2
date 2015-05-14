

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
public partial class ValidarCEN
{
private IValidarCAD _IValidarCAD;

public ValidarCEN()
{
        this._IValidarCAD = new ValidarCAD ();
}

public ValidarCEN(IValidarCAD _IValidarCAD)
{
        this._IValidarCAD = _IValidarCAD;
}

public IValidarCAD get_IValidarCAD ()
{
        return this._IValidarCAD;
}

public int Crear (string p_usuario)
{
        ValidarEN validarEN = null;
        int oid;

        //Initialized ValidarEN
        validarEN = new ValidarEN ();

        if (p_usuario != null) {
                validarEN.Usuario = new BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN ();
                validarEN.Usuario.NIF = p_usuario;
        }

        //Call to ValidarCAD

        oid = _IValidarCAD.Crear (validarEN);
        return oid;
}
}
}
