

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
public partial class SeguimientoClienteCEN
{
private ISeguimientoClienteCAD _ISeguimientoClienteCAD;

public SeguimientoClienteCEN()
{
        this._ISeguimientoClienteCAD = new SeguimientoClienteCAD ();
}

public SeguimientoClienteCEN(ISeguimientoClienteCAD _ISeguimientoClienteCAD)
{
        this._ISeguimientoClienteCAD = _ISeguimientoClienteCAD;
}

public ISeguimientoClienteCAD get_ISeguimientoClienteCAD ()
{
        return this._ISeguimientoClienteCAD;
}

public string CrearSegCliente (string p_idSeguimiento)
{
        SeguimientoClienteEN seguimientoClienteEN = null;
        string oid;

        //Initialized SeguimientoClienteEN
        seguimientoClienteEN = new SeguimientoClienteEN ();
        seguimientoClienteEN.IdSeguimiento = p_idSeguimiento;

        //Call to SeguimientoClienteCAD

        oid = _ISeguimientoClienteCAD.CrearSegCliente (seguimientoClienteEN);
        return oid;
}
}
}
