
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
public partial class PedidoCAD : BasicCAD, IPedidoCAD
{
public PedidoCAD() : base ()
{
}

public PedidoCAD(ISession sessionAux) : base (sessionAux)
{
}



public PedidoEN ReadOIDDefault (int idPedido)
{
        PedidoEN pedidoEN = null;

        try
        {
                SessionInitializeTransaction ();
                pedidoEN = (PedidoEN)session.Get (typeof(PedidoEN), idPedido);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedidoEN;
}


public int CrearPedido (PedidoEN pedido)
{
        try
        {
                SessionInitializeTransaction ();
                if (pedido.Administrador != null) {
                        pedido.Administrador = (BalumaProjectGenNHibernate.EN.BalumaProject.AdministradorEN)session.Load (typeof(BalumaProjectGenNHibernate.EN.BalumaProject.AdministradorEN), pedido.Administrador.NIF);

                        pedido.Administrador.Pedido = pedido;
                }
                if (pedido.Cliente != null) {
                        pedido.Cliente = (BalumaProjectGenNHibernate.EN.BalumaProject.ClienteEN)session.Load (typeof(BalumaProjectGenNHibernate.EN.BalumaProject.ClienteEN), pedido.Cliente.NIF);

                        pedido.Cliente.Pedidos.Add (pedido);
                }

                session.Save (pedido);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedido.IdPedido;
}

public void ModificarPedido (PedidoEN pedido)
{
        try
        {
                SessionInitializeTransaction ();
                PedidoEN pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), pedido.IdPedido);

                pedidoEN.Fecha = pedido.Fecha;


                pedidoEN.Estado = pedido.Estado;


                pedidoEN.TipoPago = pedido.TipoPago;

                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarPedido (int idPedido)
{
        try
        {
                SessionInitializeTransaction ();
                PedidoEN pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), idPedido);
                session.Delete (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void AnyadirLinea (int p_Pedido_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs)
{
        BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedidoEN = null;
        try
        {
                SessionInitializeTransaction ();
                pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), p_Pedido_OID);
                BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN lineaPedidoENAux = null;
                if (pedidoEN.LineaPedido == null) {
                        pedidoEN.LineaPedido = new System.Collections.Generic.List<BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN>();
                }

                foreach (int item in p_lineaPedido_OIDs) {
                        lineaPedidoENAux = new BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN ();
                        lineaPedidoENAux = (BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN)session.Load (typeof(BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN), item);
                        lineaPedidoENAux.Pedido = pedidoEN;

                        pedidoEN.LineaPedido.Add (lineaPedidoENAux);
                }


                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void BorrarLinea (int p_Pedido_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedidoEN = null;
                pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), p_Pedido_OID);

                BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN lineaPedidoENAux = null;
                if (pedidoEN.LineaPedido != null) {
                        foreach (int item in p_lineaPedido_OIDs) {
                                lineaPedidoENAux = (BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN)session.Load (typeof(BalumaProjectGenNHibernate.EN.BalumaProject.LineaPedidoEN), item);
                                if (pedidoEN.LineaPedido.Contains (lineaPedidoENAux) == true) {
                                        pedidoEN.LineaPedido.Remove (lineaPedidoENAux);
                                        lineaPedidoENAux.Pedido = null;
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_lineaPedido_OIDs you are trying to unrelationer, doesn't exist in PedidoEN");
                        }
                }

                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN> ObtenerPorCliente (string p_cliente)
{
        System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PedidoEN self where FROM PedidoEN pedido WHERE pedido.Cliente.NIF = :p_cliente";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PedidoENObtenerPorClienteHQL");
                query.SetParameter ("p_cliente", p_cliente);

                result = query.List<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
