

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
public partial class FacturaCEN
{
private IFacturaCAD _IFacturaCAD;

public FacturaCEN()
{
        this._IFacturaCAD = new FacturaCAD ();
}

public FacturaCEN(IFacturaCAD _IFacturaCAD)
{
        this._IFacturaCAD = _IFacturaCAD;
}

public IFacturaCAD get_IFacturaCAD ()
{
        return this._IFacturaCAD;
}

public int CrearFactura (int p_id, string p_HTML)
{
        FacturaEN facturaEN = null;
        int oid;

        //Initialized FacturaEN
        facturaEN = new FacturaEN ();
        facturaEN.Id = p_id;

        facturaEN.HTML = p_HTML;

        //Call to FacturaCAD

        oid = _IFacturaCAD.CrearFactura (facturaEN);
        return oid;
}
}
}
