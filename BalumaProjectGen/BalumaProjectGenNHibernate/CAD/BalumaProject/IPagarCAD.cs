
using System;
using BalumaProjectGenNHibernate.EN.BalumaProject;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial interface IPagarCAD
{
PagarEN ReadOIDDefault (int id);



int Crear (PagarEN pagar);
}
}
