
using System;
using BalumaProjectGenNHibernate.EN.BalumaProject;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial interface IClienteCAD
{
ClienteEN ReadOIDDefault (string NIF);

string CrearCliente (ClienteEN cliente);

void ModificarCliente (ClienteEN cliente);
}
}
