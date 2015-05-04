
using System;

namespace BalumaProjectGenNHibernate.EN.BalumaProject
{
public partial class ClienteEN                  :                           BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN


{
/**
 *
 */

private string localidad;

/**
 *
 */

private string codigoPostal;

/**
 *
 */

private string numCuentaBancaria;

/**
 *
 */

private string telefono;

/**
 *
 */

private BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN carrito;

/**
 *
 */

private BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido;





public virtual string Localidad {
        get { return localidad; } set { localidad = value;  }
}


public virtual string CodigoPostal {
        get { return codigoPostal; } set { codigoPostal = value;  }
}


public virtual string NumCuentaBancaria {
        get { return numCuentaBancaria; } set { numCuentaBancaria = value;  }
}


public virtual string Telefono {
        get { return telefono; } set { telefono = value;  }
}


public virtual BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN Carrito {
        get { return carrito; } set { carrito = value;  }
}


public virtual BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}





public ClienteEN() : base ()
{
}



public ClienteEN(string nIF, string localidad, string codigoPostal, string numCuentaBancaria, string telefono, BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN carrito, BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido, string apellidos, string password, string username, BalumaProjectGenNHibernate.EN.BalumaProject.ValidarEN validar, string nombre)
{
        this.init (nIF, localidad, codigoPostal, numCuentaBancaria, telefono, carrito, pedido, apellidos, password, username, validar, nombre);
}


public ClienteEN(ClienteEN cliente)
{
        this.init (cliente.NIF, cliente.Localidad, cliente.CodigoPostal, cliente.NumCuentaBancaria, cliente.Telefono, cliente.Carrito, cliente.Pedido, cliente.Apellidos, cliente.Password, cliente.Username, cliente.Validar, cliente.Nombre);
}

private void init (string nIF, string localidad, string codigoPostal, string numCuentaBancaria, string telefono, BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN carrito, BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido, string apellidos, string password, string username, BalumaProjectGenNHibernate.EN.BalumaProject.ValidarEN validar, string nombre)
{
        this.NIF = NIF;


        this.Localidad = localidad;

        this.CodigoPostal = codigoPostal;

        this.NumCuentaBancaria = numCuentaBancaria;

        this.Telefono = telefono;

        this.Carrito = carrito;

        this.Pedido = pedido;

        this.Apellidos = apellidos;

        this.Password = password;

        this.Username = username;

        this.Validar = validar;

        this.Nombre = nombre;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ClienteEN t = obj as ClienteEN;
        if (t == null)
                return false;
        if (NIF.Equals (t.NIF))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.NIF.GetHashCode ();
        return hash;
}
}
}
