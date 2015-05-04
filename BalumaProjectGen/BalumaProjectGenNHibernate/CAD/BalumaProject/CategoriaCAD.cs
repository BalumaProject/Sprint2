
using System;
using System.Text;
using BalumaProjectGenNHibernate.CEN.BalumaProject;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using BalumaProjectGenNHibernate.EN.BalumaProject;
using BalumaProjectGenNHibernate.Exceptions;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial class CategoriaCAD : BasicCAD, ICategoriaCAD
{
public CategoriaCAD() : base ()
{
}

public CategoriaCAD(ISession sessionAux) : base (sessionAux)
{
}



public CategoriaEN ReadOIDDefault (string nombre)
{
        CategoriaEN categoriaEN = null;

        try
        {
                SessionInitializeTransaction ();
                categoriaEN = (CategoriaEN)session.Get (typeof(CategoriaEN), nombre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in CategoriaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return categoriaEN;
}


public string CrearCategoria (CategoriaEN categoria)
{
        try
        {
                SessionInitializeTransaction ();
                if (categoria.Producto != null) {
                        categoria.Producto = (BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN)session.Load (typeof(BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN), categoria.Producto.IdProducto);

                        categoria.Producto.Categoria.Add (categoria);
                }

                session.Save (categoria);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in CategoriaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return categoria.Nombre;
}

public void ModificarCategoria (CategoriaEN categoria)
{
        try
        {
                SessionInitializeTransaction ();
                CategoriaEN categoriaEN = (CategoriaEN)session.Load (typeof(CategoriaEN), categoria.Nombre);

                categoriaEN.Descripcion = categoria.Descripcion;

                session.Update (categoriaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in CategoriaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarCategoria (string nombre)
{
        try
        {
                SessionInitializeTransaction ();
                CategoriaEN categoriaEN = (CategoriaEN)session.Load (typeof(CategoriaEN), nombre);
                session.Delete (categoriaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in CategoriaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
