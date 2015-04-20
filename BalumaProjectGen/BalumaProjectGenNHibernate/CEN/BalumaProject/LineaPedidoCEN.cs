

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
public partial class LineaPedidoCEN
{
private ILineaPedidoCAD _ILineaPedidoCAD;

public LineaPedidoCEN()
{
        this._ILineaPedidoCAD = new LineaPedidoCAD ();
}

public LineaPedidoCEN(ILineaPedidoCAD _ILineaPedidoCAD)
{
        this._ILineaPedidoCAD = _ILineaPedidoCAD;
}

public ILineaPedidoCAD get_ILineaPedidoCAD ()
{
        return this._ILineaPedidoCAD;
}

public int CrearLinea (int p_producto, int p_pedido, int p_numero)
{
        LineaPedidoEN lineaPedidoEN = null;
        int oid;

        //Initialized LineaPedidoEN
        lineaPedidoEN = new LineaPedidoEN ();

        if (p_producto != -1) {
                lineaPedidoEN.Producto = new BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN ();
                lineaPedidoEN.Producto.IdProducto = p_producto;
        }


        if (p_pedido != -1) {
                lineaPedidoEN.Pedido = new BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN ();
                lineaPedidoEN.Pedido.IdPedido = p_pedido;
        }

        lineaPedidoEN.Numero = p_numero;

        //Call to LineaPedidoCAD

        oid = _ILineaPedidoCAD.CrearLinea (lineaPedidoEN);
        return oid;
}

public void ModificarLinea (int p_LineaPedido_OID)
{
        LineaPedidoEN lineaPedidoEN = null;

        //Initialized LineaPedidoEN
        lineaPedidoEN = new LineaPedidoEN ();
        lineaPedidoEN.Numero = p_LineaPedido_OID;
        //Call to LineaPedidoCAD

        _ILineaPedidoCAD.ModificarLinea (lineaPedidoEN);
}
}
}
