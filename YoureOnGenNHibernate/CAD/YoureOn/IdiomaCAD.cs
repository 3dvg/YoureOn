
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
 * Clase Idioma:
 *
 */

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial class IdiomaCAD : BasicCAD, IIdiomaCAD
{
public IdiomaCAD() : base ()
{
}

public IdiomaCAD(ISession sessionAux) : base (sessionAux)
{
}



public IdiomaEN ReadOIDDefault (string idioma
                                )
{
        IdiomaEN idiomaEN = null;

        try
        {
                SessionInitializeTransaction ();
                idiomaEN = (IdiomaEN)session.Get (typeof(IdiomaEN), idioma);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in IdiomaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return idiomaEN;
}

public System.Collections.Generic.IList<IdiomaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IdiomaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IdiomaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IdiomaEN>();
                        else
                                result = session.CreateCriteria (typeof(IdiomaEN)).List<IdiomaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in IdiomaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IdiomaEN idioma)
{
        try
        {
                SessionInitializeTransaction ();
                IdiomaEN idiomaEN = (IdiomaEN)session.Load (typeof(IdiomaEN), idioma.Idioma);

                idiomaEN.Descripcion = idioma.Descripcion;

                session.Update (idiomaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in IdiomaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string New_ (IdiomaEN idioma)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (idioma);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in IdiomaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return idioma.Idioma;
}

public void Modify (IdiomaEN idioma)
{
        try
        {
                SessionInitializeTransaction ();
                IdiomaEN idiomaEN = (IdiomaEN)session.Load (typeof(IdiomaEN), idioma.Idioma);

                idiomaEN.Descripcion = idioma.Descripcion;

                session.Update (idiomaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in IdiomaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string idioma
                     )
{
        try
        {
                SessionInitializeTransaction ();
                IdiomaEN idiomaEN = (IdiomaEN)session.Load (typeof(IdiomaEN), idioma);
                session.Delete (idiomaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in IdiomaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
