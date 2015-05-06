
using System;
using BalumaProjectGenNHibernate.EN.BalumaProject;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial interface ISeguimientoClienteCAD
{
SeguimientoClienteEN ReadOIDDefault (string idSeguimiento);


string CrearSegCliente (SeguimientoClienteEN seguimientoCliente);
}
}
