

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
 *      Definition of the class FooterCEN
 *
 */
public partial class FooterCEN
{
private IFooterCAD _IFooterCAD;

public FooterCEN()
{
        this._IFooterCAD = new FooterCAD ();
}

public FooterCEN(IFooterCAD _IFooterCAD)
{
        this._IFooterCAD = _IFooterCAD;
}

public IFooterCAD get_IFooterCAD ()
{
        return this._IFooterCAD;
}

public int New_ ()
{
        FooterEN footerEN = null;
        int oid;

        //Initialized FooterEN
        footerEN = new FooterEN ();
        //Call to FooterCAD

        oid = _IFooterCAD.New_ (footerEN);
        return oid;
}

public void Modify (int p_Footer_OID)
{
        FooterEN footerEN = null;

        //Initialized FooterEN
        footerEN = new FooterEN ();
        footerEN.Id = p_Footer_OID;
        //Call to FooterCAD

        _IFooterCAD.Modify (footerEN);
}

public void Destroy (int id
                     )
{
        _IFooterCAD.Destroy (id);
}
}
}
