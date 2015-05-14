
using System;

namespace BalumaProjectGenNHibernate.EN.BalumaProject
{
public partial class CategoriaEN
{
/**
 *
 */

private string nombre;

/**
 *
 */

private string descripcion;

/**
 *
 */

private System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> producto;





public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}


public virtual System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> Producto {
        get { return producto; } set { producto = value;  }
}





public CategoriaEN()
{
        producto = new System.Collections.Generic.List<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN>();
}



public CategoriaEN(string nombre, string descripcion, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> producto)
{
        this.init (nombre, descripcion, producto);
}


public CategoriaEN(CategoriaEN categoria)
{
        this.init (categoria.Nombre, categoria.Descripcion, categoria.Producto);
}

private void init (string nombre, string descripcion, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN> producto)
{
        this.Nombre = nombre;


        this.Descripcion = descripcion;

        this.Producto = producto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CategoriaEN t = obj as CategoriaEN;
        if (t == null)
                return false;
        if (Nombre.Equals (t.Nombre))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Nombre.GetHashCode ();
        return hash;
}
}
}
