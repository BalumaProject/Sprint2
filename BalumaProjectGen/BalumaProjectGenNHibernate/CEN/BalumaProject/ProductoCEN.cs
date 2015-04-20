

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
public partial class ProductoCEN
{
private IProductoCAD _IProductoCAD;

public ProductoCEN()
{
        this._IProductoCAD = new ProductoCAD ();
}

public ProductoCEN(IProductoCAD _IProductoCAD)
{
        this._IProductoCAD = _IProductoCAD;
}

public IProductoCAD get_IProductoCAD ()
{
        return this._IProductoCAD;
}

public int CrearProducto (int p_idProducto, int p_precio, string p_administrador)
{
        ProductoEN productoEN = null;
        int oid;

        //Initialized ProductoEN
        productoEN = new ProductoEN ();
        productoEN.IdProducto = p_idProducto;

        productoEN.Precio = p_precio;


        if (p_administrador != null) {
                productoEN.Administrador = new BalumaProjectGenNHibernate.EN.BalumaProject.AdministradorEN ();
                productoEN.Administrador.NIF = p_administrador;
        }

        //Call to ProductoCAD

        oid = _IProductoCAD.CrearProducto (productoEN);
        return oid;
}

public void ModificarProducto (int p_Producto_OID, int p_precio)
{
        ProductoEN productoEN = null;

        //Initialized ProductoEN
        productoEN = new ProductoEN ();
        productoEN.IdProducto = p_Producto_OID;
        productoEN.Precio = p_precio;
        //Call to ProductoCAD

        _IProductoCAD.ModificarProducto (productoEN);
}

public void BorrarProducto (int idProducto)
{
        _IProductoCAD.BorrarProducto (idProducto);
}
}
}
