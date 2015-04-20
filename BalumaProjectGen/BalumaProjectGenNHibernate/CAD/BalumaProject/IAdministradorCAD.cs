
using System;
using BalumaProjectGenNHibernate.EN.BalumaProject;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial interface IAdministradorCAD
{
AdministradorEN ReadOIDDefault (string NIF);



string CrearAdministrador (AdministradorEN administrador);

void ModifcarAdministrador (AdministradorEN administrador);
}
}
