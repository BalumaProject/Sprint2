
using System;
using BalumaProjectGenNHibernate.EN.BalumaProject;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial interface ISeguimientoAdminCAD
{
SeguimientoAdminEN ReadOIDDefault (string idSeguimiento);


string CrearSegAdmin (SeguimientoAdminEN seguimientoAdmin);
}
}
