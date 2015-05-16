
using System;
using BalumaProjectGenNHibernate.EN.BalumaProject;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial interface IClienteCAD
{
ClienteEN ReadOIDDefault (string NIF);

string CrearCliente (ClienteEN cliente);

void ModificarCliente (ClienteEN cliente);



System.Collections.Generic.IList<ClienteEN> ObtenerTodos (int first, int size);


ClienteEN Obtener (string NIF);
}
}
