
using System;
using BalumaProjectGenNHibernate.EN.BalumaProject;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (string NIF);

string CrearUsuario (UsuarioEN usuario);

BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN LeerPorNombreCliente (string p_username);


BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN LeerPorNombreAdministrador (string p_username);


void BorrarUsuario (string NIF);
}
}
