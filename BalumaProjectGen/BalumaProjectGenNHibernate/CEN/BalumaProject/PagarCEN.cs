

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
public partial class PagarCEN
{
private IPagarCAD _IPagarCAD;

public PagarCEN()
{
        this._IPagarCAD = new PagarCAD ();
}

public PagarCEN(IPagarCAD _IPagarCAD)
{
        this._IPagarCAD = _IPagarCAD;
}

public IPagarCAD get_IPagarCAD ()
{
        return this._IPagarCAD;
}

public int Crear ()
{
        PagarEN pagarEN = null;
        int oid;

        //Initialized PagarEN
        pagarEN = new PagarEN ();
        //Call to PagarCAD

        oid = _IPagarCAD.Crear (pagarEN);
        return oid;
}
}
}
