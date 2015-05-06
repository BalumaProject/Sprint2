
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

private int precio;

/**
 *
 */

private BalumaProjectGenNHibernate.EN.BalumaProject.AdministradorEN administrador;

/**
 *
 */

private System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.CategoriaEN> categoria;

/**
 *
 */

private System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN> lineaPedido;

/**
 *
 */

private System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN> carrito;





public virtual int IdProducto {
        get { return idProducto; } set { idProducto = value;  }
}


public virtual int Precio {
        get { return precio; } set { precio = value;  }
}


public virtual BalumaProjectGenNHibernate.EN.BalumaProject.AdministradorEN Administrador {
        get { return administrador; } set { administrador = value;  }
}


public virtual System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.CategoriaEN> Categoria {
        get { return categoria; } set { categoria = value;  }
}


public virtual System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN> LineaPedido {
        get { return lineaPedido; } set { lineaPedido = value;  }
}


public virtual System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN> Carrito {
        get { return carrito; } set { carrito = value;  }
}





public ProductoEN()
{
        categoria = new System.Collections.Generic.List<BalumaProjectGenNHibernate.EN.BalumaProject.CategoriaEN>();
        lineaPedido = new System.Collections.Generic.List<BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN>();
        carrito = new System.Collections.Generic.List<BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN>();
}



public ProductoEN(int idProducto, int precio, BalumaProjectGenNHibernate.EN.BalumaProject.AdministradorEN administrador, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.CategoriaEN> categoria, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN> lineaPedido, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN> carrito)
{
        this.init (idProducto, precio, administrador, categoria, lineaPedido, carrito);
}


public ProductoEN(ProductoEN producto)
{
        this.init (producto.IdProducto, producto.Precio, producto.Administrador, producto.Categoria, producto.LineaPedido, producto.Carrito);
}

private void init (int idProducto, int precio, BalumaProjectGenNHibernate.EN.BalumaProject.AdministradorEN administrador, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.CategoriaEN> categoria, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN> lineaPedido, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN> carrito)
{
        this.IdProducto = idProducto;


        this.Precio = precio;

        this.Administrador = administrador;

        this.Categoria = categoria;

        this.LineaPedido = lineaPedido;

        this.Carrito = carrito;
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
