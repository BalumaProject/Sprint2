
using System;
using System.Collections.Generic;

namespace BalumaProjectGenNHibernate.EN.BalumaProject
{
<<<<<<< HEAD
    public partial class ClienteEN : UsuarioEN
    {
        private string localidad;
        private string codigoPostal;
        private string numCuentaBancaria;
        private string telefono;
        private PedidoEN pedido;
        private IList<CarritoEN> carrito;
        private string email;
        private string url_foto;

        public virtual string Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public virtual string CodigoPostal
        {
            get { return codigoPostal; }
            set { codigoPostal = value; }
        }

        public virtual string NumCuentaBancaria
        {
            get { return numCuentaBancaria; }
            set { numCuentaBancaria = value; }
        }

        public virtual string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public virtual PedidoEN Pedido
        {
            get { return pedido; }
            set { pedido = value; }
        }

        public virtual IList<CarritoEN> Carrito
        {
            get { return carrito; }
            set { carrito = value; }
        }

        public virtual string Email
        {
            get { return email; }
            set { email = value; }
        }

        public virtual string Url_foto
        {
            get { return url_foto; }
            set { url_foto = value; }
        }

        public ClienteEN()
            : base()
        {
            carrito = new List<CarritoEN>();
        }

        public ClienteEN(string nIF, string localidad, string codigoPostal, 
            string numCuentaBancaria, string telefono, PedidoEN pedido, IList<CarritoEN> carrito, 
            string email, string url_foto, string apellidos, string password, string username, 
            ValidarEN validar, string nombre)
        {
            this.init(nIF, localidad, codigoPostal, numCuentaBancaria, telefono, 
                pedido, carrito, email, url_foto, apellidos, password, username, validar, nombre);
        }

        public ClienteEN(ClienteEN cliente)
        {
            this.init(cliente.NIF, cliente.Localidad, cliente.CodigoPostal, cliente.NumCuentaBancaria, 
                cliente.Telefono, cliente.Pedido, cliente.Carrito, cliente.Email, cliente.Url_foto, 
                cliente.Apellidos, cliente.Password, cliente.Username, cliente.Validar, cliente.Nombre);
        }

        private void init(string nIF, string localidad, string codigoPostal, string numCuentaBancaria, 
            string telefono, PedidoEN pedido, IList<CarritoEN> carrito, string email, string url_foto, 
            string apellidos, string password, string username, ValidarEN validar, string nombre)
        {
            this.NIF = NIF;
            this.Localidad = localidad;
            this.CodigoPostal = codigoPostal;
            this.NumCuentaBancaria = numCuentaBancaria;
            this.Telefono = telefono;
            this.Pedido = pedido;
            this.Carrito = carrito;
            this.Email = email;
            this.Url_foto = url_foto;
            this.Apellidos = apellidos;
            this.Password = password;
            this.Username = username;
            this.Validar = validar;
            this.Nombre = nombre;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
=======
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

private BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido;

/**
 *
 */

private System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN> carrito;

/**
 *
 */

private string email;

/**
 *
 */

private string url_foto;





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


public virtual BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}


public virtual System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN> Carrito {
        get { return carrito; } set { carrito = value;  }
}


public virtual string Email {
        get { return email; } set { email = value;  }
}


public virtual string Url_foto {
        get { return url_foto; } set { url_foto = value;  }
}





public ClienteEN() : base ()
{
        carrito = new System.Collections.Generic.List<BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN>();
}



public ClienteEN(string nIF, string localidad, string codigoPostal, string numCuentaBancaria, string telefono, BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN> carrito, string email, string url_foto, string apellidos, string password, string username, BalumaProjectGenNHibernate.EN.BalumaProject.ValidarEN validar, string nombre, BalumaProjectGenNHibernate.EN.BalumaProject.AdministradorEN administrador)
{
        this.init (nIF, localidad, codigoPostal, numCuentaBancaria, telefono, pedido, carrito, email, url_foto, apellidos, password, username, validar, nombre, administrador);
}


public ClienteEN(ClienteEN cliente)
{
        this.init (cliente.NIF, cliente.Localidad, cliente.CodigoPostal, cliente.NumCuentaBancaria, cliente.Telefono, cliente.Pedido, cliente.Carrito, cliente.Email, cliente.Url_foto, cliente.Apellidos, cliente.Password, cliente.Username, cliente.Validar, cliente.Nombre, cliente.Administrador);
}

private void init (string nIF, string localidad, string codigoPostal, string numCuentaBancaria, string telefono, BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.CarritoEN> carrito, string email, string url_foto, string apellidos, string password, string username, BalumaProjectGenNHibernate.EN.BalumaProject.ValidarEN validar, string nombre, BalumaProjectGenNHibernate.EN.BalumaProject.AdministradorEN administrador)
{
        this.NIF = NIF;


        this.Localidad = localidad;

        this.CodigoPostal = codigoPostal;

        this.NumCuentaBancaria = numCuentaBancaria;

        this.Telefono = telefono;

        this.Pedido = pedido;

        this.Carrito = carrito;

        this.Email = email;

        this.Url_foto = url_foto;

        this.Apellidos = apellidos;

        this.Password = password;

        this.Username = username;

        this.Validar = validar;

        this.Nombre = nombre;

        this.Administrador = administrador;
}

public override bool Equals (object obj)
{
        if (obj == null)
>>>>>>> diagrama-UML
                return false;
            ClienteEN t = obj as ClienteEN;
            if (t == null)
                return false;
            if (NIF.Equals(t.NIF))
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash += this.NIF.GetHashCode();
            return hash;
        }
    }
}
