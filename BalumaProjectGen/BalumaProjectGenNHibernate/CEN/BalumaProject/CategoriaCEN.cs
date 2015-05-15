

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using BalumaProjectGenNHibernate.EN.BalumaProject;
using BalumaProjectGenNHibernate.CAD.BalumaProject;

namespace BalumaProjectGenNHibernate.CEN.BalumaProject
{
public partial class CategoriaCEN
{
private ICategoriaCAD _ICategoriaCAD;

public CategoriaCEN()
{
        this._ICategoriaCAD = new CategoriaCAD ();
}

public CategoriaCEN(ICategoriaCAD _ICategoriaCAD)
{
        this._ICategoriaCAD = _ICategoriaCAD;
}

public ICategoriaCAD get_ICategoriaCAD ()
{
        return this._ICategoriaCAD;
}

public string CrearCategoria (string p_nombre, string p_descripcion)
{
        CategoriaEN categoriaEN = null;
        string oid;

        //Initialized CategoriaEN
        categoriaEN = new CategoriaEN ();
        categoriaEN.Nombre = p_nombre;

        categoriaEN.Descripcion = p_descripcion;

        //Call to CategoriaCAD

        oid = _ICategoriaCAD.CrearCategoria (categoriaEN);
        return oid;
}

public void ModificarCategoria (string p_Categoria_OID, string p_descripcion)
{
        CategoriaEN categoriaEN = null;

        //Initialized CategoriaEN
        categoriaEN = new CategoriaEN ();
        categoriaEN.Nombre = p_Categoria_OID;
        categoriaEN.Descripcion = p_descripcion;
        //Call to CategoriaCAD

        _ICategoriaCAD.ModificarCategoria (categoriaEN);
}

public void BorrarCategoria (string nombre)
{
        _ICategoriaCAD.BorrarCategoria (nombre);
}
}
}
