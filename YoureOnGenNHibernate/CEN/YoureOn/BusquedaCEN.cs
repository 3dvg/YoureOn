

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using YoureOnGenNHibernate.Exceptions;

using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.CAD.YoureOn;


namespace YoureOnGenNHibernate.CEN.YoureOn
{
/*
 *      Definition of the class BusquedaCEN
 *
 */
public partial class BusquedaCEN
{
private IBusquedaCAD _IBusquedaCAD;

public BusquedaCEN()
{
        this._IBusquedaCAD = new BusquedaCAD ();
}

public BusquedaCEN(IBusquedaCAD _IBusquedaCAD)
{
        this._IBusquedaCAD = _IBusquedaCAD;
}

public IBusquedaCAD get_IBusquedaCAD ()
{
        return this._IBusquedaCAD;
}

public int New_ ()
{
        BusquedaEN busquedaEN = null;
        int oid;

        //Initialized BusquedaEN
        busquedaEN = new BusquedaEN ();
        //Call to BusquedaCAD

        oid = _IBusquedaCAD.New_ (busquedaEN);
        return oid;
}

public void Modify (int p_Busqueda_OID)
{
        BusquedaEN busquedaEN = null;

        //Initialized BusquedaEN
        busquedaEN = new BusquedaEN ();
        busquedaEN.Id = p_Busqueda_OID;
        //Call to BusquedaCAD

        _IBusquedaCAD.Modify (busquedaEN);
}

public void Destroy (int id
                     )
{
        _IBusquedaCAD.Destroy (id);
}
}
}
