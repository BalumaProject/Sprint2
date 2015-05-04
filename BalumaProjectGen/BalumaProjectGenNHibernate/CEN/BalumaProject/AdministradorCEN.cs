

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
public partial class AdministradorCEN
{
private IAdministradorCAD _IAdministradorCAD;

public AdministradorCEN()
{
        this._IAdministradorCAD = new AdministradorCAD ();
}

public AdministradorCEN(IAdministradorCAD _IAdministradorCAD)
{
        this._IAdministradorCAD = _IAdministradorCAD;
}

public IAdministradorCAD get_IAdministradorCAD ()
{
        return this._IAdministradorCAD;
}

public string CrearAdministrador (string p_apellidos, string p_password, string p_username, string p_NIF, string p_nombre)
{
        AdministradorEN administradorEN = null;
        string oid;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();
        administradorEN.Apellidos = p_apellidos;

        administradorEN.Password = p_password;

        administradorEN.Username = p_username;

        administradorEN.NIF = p_NIF;

        administradorEN.Nombre = p_nombre;

        //Call to AdministradorCAD

        oid = _IAdministradorCAD.CrearAdministrador (administradorEN);
        return oid;
}

public void ModifcarAdministrador (string p_Administrador_OID, string p_apellidos, string p_password, string p_username, string p_nombre)
{
        AdministradorEN administradorEN = null;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();
        administradorEN.NIF = p_Administrador_OID;
        administradorEN.Apellidos = p_apellidos;
        administradorEN.Password = p_password;
        administradorEN.Username = p_username;
        administradorEN.Nombre = p_nombre;
        //Call to AdministradorCAD

        _IAdministradorCAD.ModifcarAdministrador (administradorEN);
}
}
}
