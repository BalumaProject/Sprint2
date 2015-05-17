
using System;

namespace BalumaProjectGenNHibernate.EN.BalumaProject
{
public partial class ProductoEN
{
/**
 *
 */

private int idProducto;

/**
 *
 */

private float precio;

/**
 *
 */

private BalumaProjectGenNHibernate.EN.BalumaProject.AdministradorEN administrador;

/**
 *
 */

private BalumaProjectGenNHibernate.EN.BalumaProject.CategoriaEN categoria;

/**
 *
 */

private System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN> lineaPedido;

/**
 *
 */

private string nombre;

/**
 *
 */

private int cantidad;





public virtual int IdProducto {
        get { return idProducto; } set { idProducto = value;  }
}


public virtual float Precio {
        get { return precio; } set { precio = value;  }
}


public virtual BalumaProjectGenNHibernate.EN.BalumaProject.AdministradorEN Administrador {
        get { return administrador; } set { administrador = value;  }
}


public virtual BalumaProjectGenNHibernate.EN.BalumaProject.CategoriaEN Categoria {
        get { return categoria; } set { categoria = value;  }
}


public virtual System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN> LineaPedido {
        get { return lineaPedido; } set { lineaPedido = value;  }
}


public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual int Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}





public ProductoEN()
{
        lineaPedido = new System.Collections.Generic.List<BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN>();
}



public ProductoEN(int idProducto, float precio, BalumaProjectGenNHibernate.EN.BalumaProject.AdministradorEN administrador, BalumaProjectGenNHibernate.EN.BalumaProject.CategoriaEN categoria, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN> lineaPedido, string nombre, int cantidad)
{
        this.init (idProducto, precio, administrador, categoria, lineaPedido, nombre, cantidad);
}


public ProductoEN(ProductoEN producto)
{
        this.init (producto.IdProducto, producto.Precio, producto.Administrador, producto.Categoria, producto.LineaPedido, producto.Nombre, producto.Cantidad);
}

private void init (int idProducto, float precio, BalumaProjectGenNHibernate.EN.BalumaProject.AdministradorEN administrador, BalumaProjectGenNHibernate.EN.BalumaProject.CategoriaEN categoria, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN> lineaPedido, string nombre, int cantidad)
{
        this.IdProducto = idProducto;


        this.Precio = precio;

        this.Administrador = administrador;

        this.Categoria = categoria;

        this.LineaPedido = lineaPedido;

        this.Nombre = nombre;

        this.Cantidad = cantidad;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ProductoEN t = obj as ProductoEN;
        if (t == null)
                return false;
        if (IdProducto.Equals (t.IdProducto))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdProducto.GetHashCode ();
        return hash;
}
}
}
