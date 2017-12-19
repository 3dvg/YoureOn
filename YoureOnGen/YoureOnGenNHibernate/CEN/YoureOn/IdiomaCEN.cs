

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
 *      Definition of the class IdiomaCEN
 *
 */
public partial class IdiomaCEN
{
private IIdiomaCAD _IIdiomaCAD;

public IdiomaCEN()
{
        this._IIdiomaCAD = new IdiomaCAD ();
}

public IdiomaCEN(IIdiomaCAD _IIdiomaCAD)
{
        this._IIdiomaCAD = _IIdiomaCAD;
}

public IIdiomaCAD get_IIdiomaCAD ()
{
        return this._IIdiomaCAD;
}

public string New_ (string p_idioma, string p_descripcion)
{
        IdiomaEN idiomaEN = null;
        string oid;

        //Initialized IdiomaEN
        idiomaEN = new IdiomaEN ();
        idiomaEN.Idioma = p_idioma;

        idiomaEN.Descripcion = p_descripcion;

        //Call to IdiomaCAD

        oid = _IIdiomaCAD.New_ (idiomaEN);
        return oid;
}

public void Modify (string p_Idioma_OID, string p_descripcion)
{
        IdiomaEN idiomaEN = null;

        //Initialized IdiomaEN
        idiomaEN = new IdiomaEN ();
        idiomaEN.Idioma = p_Idioma_OID;
        idiomaEN.Descripcion = p_descripcion;
        //Call to IdiomaCAD

        _IIdiomaCAD.Modify (idiomaEN);
}

public void Destroy (string idioma
                     )
{
        _IIdiomaCAD.Destroy (idioma);
}
}
}
