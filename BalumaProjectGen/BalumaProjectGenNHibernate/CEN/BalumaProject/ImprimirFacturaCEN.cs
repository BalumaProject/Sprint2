

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
public partial class ImprimirFacturaCEN
{
private IImprimirFacturaCAD _IImprimirFacturaCAD;

public ImprimirFacturaCEN()
{
        this._IImprimirFacturaCAD = new ImprimirFacturaCAD ();
}

public ImprimirFacturaCEN(IImprimirFacturaCAD _IImprimirFacturaCAD)
{
        this._IImprimirFacturaCAD = _IImprimirFacturaCAD;
}

public IImprimirFacturaCAD get_IImprimirFacturaCAD ()
{
        return this._IImprimirFacturaCAD;
}

public int CrearFactura (int p_id, string p_HTML)
{
        ImprimirFacturaEN imprimirFacturaEN = null;
        int oid;

        //Initialized ImprimirFacturaEN
        imprimirFacturaEN = new ImprimirFacturaEN ();
        imprimirFacturaEN.Id = p_id;

        imprimirFacturaEN.HTML = p_HTML;

        //Call to ImprimirFacturaCAD

        oid = _IImprimirFacturaCAD.CrearFactura (imprimirFacturaEN);
        return oid;
}
}
}
