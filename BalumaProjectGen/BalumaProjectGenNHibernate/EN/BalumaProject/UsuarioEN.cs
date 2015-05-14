
using System;

namespace BalumaProjectGenNHibernate.EN.BalumaProject
{
public partial class UsuarioEN
{
/**
 *
 */

private string apellidos;

/**
 *
 */

private string password;

/**
 *
 */

private string username;

/**
 *
 */

private BalumaProjectGenNHibernate.EN.BalumaProject.ValidarEN validar;

/**
 *
 */

private string nIF;

/**
 *
 */

private string nombre;





public virtual string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}


public virtual string Password {
        get { return password; } set { password = value;  }
}


public virtual string Username {
        get { return username; } set { username = value;  }
}


public virtual BalumaProjectGenNHibernate.EN.BalumaProject.ValidarEN Validar {
        get { return validar; } set { validar = value;  }
}


public virtual string NIF {
        get { return nIF; } set { nIF = value;  }
}


public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}





public UsuarioEN()
{
}



public UsuarioEN(string nIF, string apellidos, string password, string username, BalumaProjectGenNHibernate.EN.BalumaProject.ValidarEN validar, string nombre)
{
        this.init (nIF, apellidos, password, username, validar, nombre);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (usuario.NIF, usuario.Apellidos, usuario.Password, usuario.Username, usuario.Validar, usuario.Nombre);
}

private void init (string nIF, string apellidos, string password, string username, BalumaProjectGenNHibernate.EN.BalumaProject.ValidarEN validar, string nombre)
{
        this.NIF = NIF;


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
        UsuarioEN t = obj as UsuarioEN;
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
