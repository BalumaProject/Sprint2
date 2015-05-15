
using System;
using BalumaProjectGenNHibernate.EN.BalumaProject;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial interface ISeguimientoCAD
{
SeguimientoEN ReadOIDDefault (string idSeguimiento);


string CrearSeguimiento (SeguimientoEN seguimiento);
}
}
