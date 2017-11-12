
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
 * Clase ReporteComentario:
 *
 */

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial class ReporteComentarioCAD : BasicCAD, IReporteComentarioCAD
{
public ReporteComentarioCAD() : base ()
{
}

public ReporteComentarioCAD(ISession sessionAux) : base (sessionAux)
{
}



public ReporteComentarioEN ReadOIDDefault (int id
                                           )
{
        ReporteComentarioEN reporteComentarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                reporteComentarioEN = (ReporteComentarioEN)session.Get (typeof(ReporteComentarioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporteComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reporteComentarioEN;
}

public System.Collections.Generic.IList<ReporteComentarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ReporteComentarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ReporteComentarioEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ReporteComentarioEN>();
                        else
                                result = session.CreateCriteria (typeof(ReporteComentarioEN)).List<ReporteComentarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporteComentarioCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ReporteComentarioEN reporteComentario)
{
        try
        {
                SessionInitializeTransaction ();
                ReporteComentarioEN reporteComentarioEN = (ReporteComentarioEN)session.Load (typeof(ReporteComentarioEN), reporteComentario.Id);
                session.Update (reporteComentarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporteComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ReporteComentarioEN reporteComentario)
{
        try
        {
                SessionInitializeTransaction ();
                if (reporteComentario.Usuario != null) {
                        // Argumento OID y no colección.
                        reporteComentario.Usuario = (YoureOnGenNHibernate.EN.YoureOn.UsuarioEN)session.Load (typeof(YoureOnGenNHibernate.EN.YoureOn.UsuarioEN), reporteComentario.Usuario.Email);

                        reporteComentario.Usuario.Reporte
                        .Add (reporteComentario);
                }

                session.Save (reporteComentario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporteComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reporteComentario.Id;
}

public void Modify (ReporteComentarioEN reporteComentario)
{
        try
        {
                SessionInitializeTransaction ();
                ReporteComentarioEN reporteComentarioEN = (ReporteComentarioEN)session.Load (typeof(ReporteComentarioEN), reporteComentario.Id);
                session.Update (reporteComentarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporteComentarioCAD.", ex);
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
                ReporteComentarioEN reporteComentarioEN = (ReporteComentarioEN)session.Load (typeof(ReporteComentarioEN), id);
                session.Delete (reporteComentarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporteComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
