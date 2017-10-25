
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
 * Clase YoureOn:
 *
 */

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial class YoureOnCAD : BasicCAD, IYoureOnCAD
{
public YoureOnCAD() : base ()
{
}

public YoureOnCAD(ISession sessionAux) : base (sessionAux)
{
}



public YoureOnEN ReadOIDDefault (int id
                                 )
{
        YoureOnEN youreOnEN = null;

        try
        {
                SessionInitializeTransaction ();
                youreOnEN = (YoureOnEN)session.Get (typeof(YoureOnEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in YoureOnCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return youreOnEN;
}

public System.Collections.Generic.IList<YoureOnEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<YoureOnEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(YoureOnEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<YoureOnEN>();
                        else
                                result = session.CreateCriteria (typeof(YoureOnEN)).List<YoureOnEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in YoureOnCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (YoureOnEN youreOn)
{
        try
        {
                SessionInitializeTransaction ();
                YoureOnEN youreOnEN = (YoureOnEN)session.Load (typeof(YoureOnEN), youreOn.Id);
                session.Update (youreOnEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in YoureOnCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (YoureOnEN youreOn)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (youreOn);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in YoureOnCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return youreOn.Id;
}

public void Modify (YoureOnEN youreOn)
{
        try
        {
                SessionInitializeTransaction ();
                YoureOnEN youreOnEN = (YoureOnEN)session.Load (typeof(YoureOnEN), youreOn.Id);
                session.Update (youreOnEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in YoureOnCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                YoureOnEN youreOnEN = (YoureOnEN)session.Load (typeof(YoureOnEN), id);
                session.Delete (youreOnEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in YoureOnCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
