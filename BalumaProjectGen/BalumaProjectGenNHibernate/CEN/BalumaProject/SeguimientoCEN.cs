

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
public partial class SeguimientoCEN
{
private ISeguimientoCAD _ISeguimientoCAD;

public SeguimientoCEN()
{
        this._ISeguimientoCAD = new SeguimientoCAD ();
}

public SeguimientoCEN(ISeguimientoCAD _ISeguimientoCAD)
{
        this._ISeguimientoCAD = _ISeguimientoCAD;
}

public ISeguimientoCAD get_ISeguimientoCAD ()
{
        return this._ISeguimientoCAD;
}

public string CrearSeguimiento (string p_idSeguimiento)
{
        SeguimientoEN seguimientoEN = null;
        string oid;

        //Initialized SeguimientoEN
        seguimientoEN = new SeguimientoEN ();
        seguimientoEN.IdSeguimiento = p_idSeguimiento;

        //Call to SeguimientoCAD

        oid = _ISeguimientoCAD.CrearSeguimiento (seguimientoEN);
        return oid;
}
}
}
