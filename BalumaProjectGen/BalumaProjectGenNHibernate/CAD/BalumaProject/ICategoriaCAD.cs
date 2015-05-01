
using System;
using BalumaProjectGenNHibernate.EN.BalumaProject;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial interface ICategoriaCAD
{
CategoriaEN ReadOIDDefault (string nombre);

string CrearCategoria (CategoriaEN categoria);

void ModificarCategoria (CategoriaEN categoria);


void BorrarCategoria (string nombre);
}
}
