
using System;
using System.Text;
using YoureOnGenNHibernate.CEN.YoureOn;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.Exceptions;


/*
 * Clase Footer:
 *
 */

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial class FooterCAD : BasicCAD, IFooterCAD
{
public FooterCAD() : base ()
{
}

public FooterCAD(ISession sessionAux) : base (sessionAux)
{
}



public FooterEN ReadOIDDefault (int id_footer
                                )
{
        FooterEN footerEN = null;

        try
        {
                SessionInitializeTransaction ();
                footerEN = (FooterEN)session.Get (typeof(FooterEN), id_footer);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in FooterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return footerEN;
}

public System.Collections.Generic.IList<FooterEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<FooterEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(FooterEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<FooterEN>();
                        else
                                result = session.CreateCriteria (typeof(FooterEN)).List<FooterEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in FooterCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (FooterEN footer)
{
        try
        {
                SessionInitializeTransaction ();
                FooterEN footerEN = (FooterEN)session.Load (typeof(FooterEN), footer.Id_footer);

                footerEN.Enlace = footer.Enlace;

                session.Update (footerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in FooterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (FooterEN footer)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (footer);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in FooterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return footer.Id_footer;
}

public void Modify (FooterEN footer)
{
        try
        {
                SessionInitializeTransaction ();
                FooterEN footerEN = (FooterEN)session.Load (typeof(FooterEN), footer.Id_footer);

                footerEN.Enlace = footer.Enlace;

                session.Update (footerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in FooterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id_footer
                     )
{
        try
        {
                SessionInitializeTransaction ();
                FooterEN footerEN = (FooterEN)session.Load (typeof(FooterEN), id_footer);
                session.Delete (footerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in FooterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
