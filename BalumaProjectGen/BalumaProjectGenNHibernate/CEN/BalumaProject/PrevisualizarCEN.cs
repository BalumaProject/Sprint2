

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
public partial class PrevisualizarCEN
{
private IPrevisualizarCAD _IPrevisualizarCAD;

public PrevisualizarCEN()
{
        this._IPrevisualizarCAD = new PrevisualizarCAD ();
}

public PrevisualizarCEN(IPrevisualizarCAD _IPrevisualizarCAD)
{
        this._IPrevisualizarCAD = _IPrevisualizarCAD;
}

public IPrevisualizarCAD get_IPrevisualizarCAD ()
{
        return this._IPrevisualizarCAD;
}

public int CrearFactura (int p_id, string p_HTML)
{
        PrevisualizarEN previsualizarEN = null;
        int oid;

        //Initialized PrevisualizarEN
        previsualizarEN = new PrevisualizarEN ();
        previsualizarEN.Id = p_id;

        previsualizarEN.HTML = p_HTML;

        //Call to PrevisualizarCAD

        oid = _IPrevisualizarCAD.CrearFactura (previsualizarEN);
        return oid;
}
}
}
