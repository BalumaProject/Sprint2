

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
public partial class SeguimientoAdminCEN
{
private ISeguimientoAdminCAD _ISeguimientoAdminCAD;

public SeguimientoAdminCEN()
{
        this._ISeguimientoAdminCAD = new SeguimientoAdminCAD ();
}

public SeguimientoAdminCEN(ISeguimientoAdminCAD _ISeguimientoAdminCAD)
{
        this._ISeguimientoAdminCAD = _ISeguimientoAdminCAD;
}

public ISeguimientoAdminCAD get_ISeguimientoAdminCAD ()
{
        return this._ISeguimientoAdminCAD;
}

public string CrearSegAdmin (string p_idSeguimiento)
{
        SeguimientoAdminEN seguimientoAdminEN = null;
        string oid;

        //Initialized SeguimientoAdminEN
        seguimientoAdminEN = new SeguimientoAdminEN ();
        seguimientoAdminEN.IdSeguimiento = p_idSeguimiento;

        //Call to SeguimientoAdminCAD

        oid = _ISeguimientoAdminCAD.CrearSegAdmin (seguimientoAdminEN);
        return oid;
}
}
}
