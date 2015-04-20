

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
public partial class ClienteCEN
{
private IClienteCAD _IClienteCAD;

public ClienteCEN()
{
        this._IClienteCAD = new ClienteCAD ();
}

public ClienteCEN(IClienteCAD _IClienteCAD)
{
        this._IClienteCAD = _IClienteCAD;
}

public IClienteCAD get_IClienteCAD ()
{
        return this._IClienteCAD;
}

public string CrearCliente (string p_apellidos, string p_password, string p_username, string p_NIF, string p_nombre, string p_localidad, string p_codigoPostal, string p_numCuentaBancaria, string p_telefono)
{
        ClienteEN clienteEN = null;
        string oid;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.Apellidos = p_apellidos;

        clienteEN.Password = p_password;

        clienteEN.Username = p_username;

        clienteEN.NIF = p_NIF;

        clienteEN.Nombre = p_nombre;

        clienteEN.Localidad = p_localidad;

        clienteEN.CodigoPostal = p_codigoPostal;

        clienteEN.NumCuentaBancaria = p_numCuentaBancaria;

        clienteEN.Telefono = p_telefono;

        //Call to ClienteCAD

        oid = _IClienteCAD.CrearCliente (clienteEN);
        return oid;
}

public void AnyadirAlCarrito (string p_Cliente_OID, int p_carrito_OID)
{
        //Call to ClienteCAD

        _IClienteCAD.AnyadirAlCarrito (p_Cliente_OID, p_carrito_OID);
}
public void QuitarDelCarrito (string p_Cliente_OID, int p_carrito_OID)
{
        //Call to ClienteCAD

        _IClienteCAD.QuitarDelCarrito (p_Cliente_OID, p_carrito_OID);
}
public void ModificarCliente (string p_Cliente_OID, string p_apellidos, string p_password, string p_username, string p_nombre, string p_localidad, string p_codigoPostal, string p_numCuentaBancaria, string p_telefono)
{
        ClienteEN clienteEN = null;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.NIF = p_Cliente_OID;
        clienteEN.Apellidos = p_apellidos;
        clienteEN.Password = p_password;
        clienteEN.Username = p_username;
        clienteEN.Nombre = p_nombre;
        clienteEN.Localidad = p_localidad;
        clienteEN.CodigoPostal = p_codigoPostal;
        clienteEN.NumCuentaBancaria = p_numCuentaBancaria;
        clienteEN.Telefono = p_telefono;
        //Call to ClienteCAD

        _IClienteCAD.ModificarCliente (clienteEN);
}
}
}
