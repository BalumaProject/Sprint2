
using System;
using BalumaProjectGenNHibernate.EN.BalumaProject;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial interface IClienteCAD
{
ClienteEN ReadOIDDefault (string NIF);



string CrearCliente (ClienteEN cliente);

void AnyadirAlCarrito (string p_Cliente_OID, int p_carrito_OID);

void QuitarDelCarrito (string p_Cliente_OID, int p_carrito_OID);

void ModificarCliente (ClienteEN cliente);
}
}
