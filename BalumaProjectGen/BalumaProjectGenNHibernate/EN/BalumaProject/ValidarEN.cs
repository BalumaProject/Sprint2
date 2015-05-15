
using System;

namespace BalumaProjectGenNHibernate.EN.BalumaProject
{
public partial class ValidarEN
{
/**
 *
 */

private BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN usuario;

/**
 *
 */

private int id;





public virtual BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}


public virtual int Id {
        get { return id; } set { id = value;  }
}





public ValidarEN()
{
}



public ValidarEN(int id, BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN usuario)
{
        this.init (id, usuario);
}


public ValidarEN(ValidarEN validar)
{
        this.init (validar.Id, validar.Usuario);
}

private void init (int id, BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN usuario)
{
        this.Id = id;


        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ValidarEN t = obj as ValidarEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
