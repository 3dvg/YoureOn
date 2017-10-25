
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
 * Clase ReporeteContenido:
 *
 */

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial class ReporeteContenidoCAD : BasicCAD, IReporeteContenidoCAD
{
public ReporeteContenidoCAD() : base ()
{
}

public ReporeteContenidoCAD(ISession sessionAux) : base (sessionAux)
{
}



public ReporeteContenidoEN ReadOIDDefault (int id
                                           )
{
        ReporeteContenidoEN reporeteContenidoEN = null;

        try
        {
                SessionInitializeTransaction ();
                reporeteContenidoEN = (ReporeteContenidoEN)session.Get (typeof(ReporeteContenidoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporeteContenidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reporeteContenidoEN;
}

public System.Collections.Generic.IList<ReporeteContenidoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ReporeteContenidoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ReporeteContenidoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ReporeteContenidoEN>();
                        else
                                result = session.CreateCriteria (typeof(ReporeteContenidoEN)).List<ReporeteContenidoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporeteContenidoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ReporeteContenidoEN reporeteContenido)
{
        try
        {
                SessionInitializeTransaction ();
                ReporeteContenidoEN reporeteContenidoEN = (ReporeteContenidoEN)session.Load (typeof(ReporeteContenidoEN), reporeteContenido.Id);

                session.Update (reporeteContenidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporeteContenidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ReporeteContenidoEN reporeteContenido)
{
        try
        {
                SessionInitializeTransaction ();
                if (reporeteContenido.Usuario != null) {
                        // Argumento OID y no colección.
                        reporeteContenido.Usuario = (YoureOnGenNHibernate.EN.YoureOn.UsuarioEN)session.Load (typeof(YoureOnGenNHibernate.EN.YoureOn.UsuarioEN), reporeteContenido.Usuario.Email);

                        reporeteContenido.Usuario.Reporte
                        .Add (reporeteContenido);
                }
                if (reporeteContenido.Contenido != null) {
                        // Argumento OID y no colección.
                        reporeteContenido.Contenido = (YoureOnGenNHibernate.EN.YoureOn.ContenidoEN)session.Load (typeof(YoureOnGenNHibernate.EN.YoureOn.ContenidoEN), reporeteContenido.Contenido.Titulo);

                        reporeteContenido.Contenido.Reporte
                        .Add (reporeteContenido);
                }

                session.Save (reporeteContenido);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporeteContenidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reporeteContenido.Id;
}

public void Modify (ReporeteContenidoEN reporeteContenido)
{
        try
        {
                SessionInitializeTransaction ();
                ReporeteContenidoEN reporeteContenidoEN = (ReporeteContenidoEN)session.Load (typeof(ReporeteContenidoEN), reporeteContenido.Id);
                session.Update (reporeteContenidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporeteContenidoCAD.", ex);
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
                ReporeteContenidoEN reporeteContenidoEN = (ReporeteContenidoEN)session.Load (typeof(ReporeteContenidoEN), id);
                session.Delete (reporeteContenidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporeteContenidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
