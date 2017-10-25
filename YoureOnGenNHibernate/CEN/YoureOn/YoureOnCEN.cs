

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
 *      Definition of the class YoureOnCEN
 *
 */
public partial class YoureOnCEN
{
private IYoureOnCAD _IYoureOnCAD;

public YoureOnCEN()
{
        this._IYoureOnCAD = new YoureOnCAD ();
}

public YoureOnCEN(IYoureOnCAD _IYoureOnCAD)
{
        this._IYoureOnCAD = _IYoureOnCAD;
}

public IYoureOnCAD get_IYoureOnCAD ()
{
        return this._IYoureOnCAD;
}

public int New_ ()
{
        YoureOnEN youreOnEN = null;
        int oid;

        //Initialized YoureOnEN
        youreOnEN = new YoureOnEN ();
        //Call to YoureOnCAD

        oid = _IYoureOnCAD.New_ (youreOnEN);
        return oid;
}

public void Modify (int p_YoureOn_OID)
{
        YoureOnEN youreOnEN = null;

        //Initialized YoureOnEN
        youreOnEN = new YoureOnEN ();
        youreOnEN.Id = p_YoureOn_OID;
        //Call to YoureOnCAD

        _IYoureOnCAD.Modify (youreOnEN);
}

public void Destroy (int id
                     )
{
        _IYoureOnCAD.Destroy (id);
}
}
}
