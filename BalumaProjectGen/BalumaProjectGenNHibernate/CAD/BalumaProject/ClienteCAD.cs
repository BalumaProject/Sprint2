
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
public partial class ClienteCAD : BasicCAD, IClienteCAD
{
public ClienteCAD() : base ()
{
}

public ClienteCAD(ISession sessionAux) : base (sessionAux)
{
}



public ClienteEN ReadOIDDefault (string NIF)
{
        ClienteEN clienteEN = null;

        try
        {
                SessionInitializeTransaction ();
                clienteEN = (ClienteEN)session.Get (typeof(ClienteEN), NIF);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return clienteEN;
}


public string CrearCliente (ClienteEN cliente)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (cliente);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cliente.NIF;
}

public void AnyadirAlCarrito (string p_Cliente_OID, int p_carrito_OID)
{
        BalumaProjectGenNHibernate.EN.BalumaProject.ClienteEN clienteEN = null;
        try
        {
                SessionInitializeTransaction ();
                clienteEN = (ClienteEN)session.Load (typeof(ClienteEN), p_Cliente_OID);
                clienteEN.Carrito = (BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN)session.Load (typeof(BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN), p_carrito_OID);

                clienteEN.Carrito.Cliente = clienteEN;




                session.Update (clienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void QuitarDelCarrito (string p_Cliente_OID, int p_carrito_OID)
{
        try
        {
                SessionInitializeTransaction ();
                BalumaProjectGenNHibernate.EN.BalumaProject.ClienteEN clienteEN = null;
                clienteEN = (ClienteEN)session.Load (typeof(ClienteEN), p_Cliente_OID);

                if (clienteEN.Carrito.IdCarrito == p_carrito_OID) {
                        clienteEN.Carrito = null;
                        BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN carritoEN = (BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN)session.Load (typeof(BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN), p_carrito_OID);
                        carritoEN.Cliente = null;
                }
                else
                        throw new ModelException ("The identifier " + p_carrito_OID + " in p_carrito_OID you are trying to unrelationer, doesn't exist in ClienteEN");

                session.Update (clienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void ModificarCliente (ClienteEN cliente)
{
        try
        {
                SessionInitializeTransaction ();
                ClienteEN clienteEN = (ClienteEN)session.Load (typeof(ClienteEN), cliente.NIF);

                clienteEN.Apellidos = cliente.Apellidos;


                clienteEN.Password = cliente.Password;


                clienteEN.Username = cliente.Username;


                clienteEN.Nombre = cliente.Nombre;


                clienteEN.Localidad = cliente.Localidad;


                clienteEN.CodigoPostal = cliente.CodigoPostal;


                clienteEN.NumCuentaBancaria = cliente.NumCuentaBancaria;


                clienteEN.Telefono = cliente.Telefono;

                session.Update (clienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
