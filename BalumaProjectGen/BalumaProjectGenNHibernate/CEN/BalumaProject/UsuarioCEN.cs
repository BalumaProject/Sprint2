

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
public partial class UsuarioCEN
{
private IUsuarioCAD _IUsuarioCAD;

public UsuarioCEN()
{
        this._IUsuarioCAD = new UsuarioCAD ();
}

public UsuarioCEN(IUsuarioCAD _IUsuarioCAD)
{
        this._IUsuarioCAD = _IUsuarioCAD;
}

public IUsuarioCAD get_IUsuarioCAD ()
{
        return this._IUsuarioCAD;
}

public string CrearUsuario (string p_apellidos, string p_password, string p_username, string p_NIF, string p_nombre)
{
        UsuarioEN usuarioEN = null;
        string oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Apellidos = p_apellidos;

        usuarioEN.Password = p_password;

        usuarioEN.Username = p_username;

        usuarioEN.NIF = p_NIF;

        usuarioEN.Nombre = p_nombre;

        //Call to UsuarioCAD

        oid = _IUsuarioCAD.CrearUsuario (usuarioEN);
        return oid;
}

public BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN LeerPorNombreCliente (string p_username)
{
        return _IUsuarioCAD.LeerPorNombreCliente (p_username);
}
public BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN LeerPorNombreAdministrador (string p_username)
{
        return _IUsuarioCAD.LeerPorNombreAdministrador (p_username);
}
public void BorrarUsuario (string NIF)
{
        _IUsuarioCAD.BorrarUsuario (NIF);
}
}
}
