
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
 * Clase ReporteContenido:
 *
 */

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial class ReporteContenidoCAD : BasicCAD, IReporteContenidoCAD
{
public ReporteContenidoCAD() : base ()
{
}

public ReporteContenidoCAD(ISession sessionAux) : base (sessionAux)
{
}



public ReporteContenidoEN ReadOIDDefault (int id_reporte
                                          )
{
        ReporteContenidoEN reporteContenidoEN = null;

        try
        {
                SessionInitializeTransaction ();
                reporteContenidoEN = (ReporteContenidoEN)session.Get (typeof(ReporteContenidoEN), id_reporte);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporteContenidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reporteContenidoEN;
}

public System.Collections.Generic.IList<ReporteContenidoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ReporteContenidoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ReporteContenidoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ReporteContenidoEN>();
                        else
                                result = session.CreateCriteria (typeof(ReporteContenidoEN)).List<ReporteContenidoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporteContenidoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ReporteContenidoEN reporteContenido)
{
        try
        {
                SessionInitializeTransaction ();
                ReporteContenidoEN reporteContenidoEN = (ReporteContenidoEN)session.Load (typeof(ReporteContenidoEN), reporteContenido.Id_reporte);

                session.Update (reporteContenidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporteContenidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ReporteContenidoEN reporteContenido)
{
        try
        {
                SessionInitializeTransaction ();
                if (reporteContenido.Usuario != null) {
                        // Argumento OID y no colección.
                        reporteContenido.Usuario = (YoureOnGenNHibernate.EN.YoureOn.UsuarioEN)session.Load (typeof(YoureOnGenNHibernate.EN.YoureOn.UsuarioEN), reporteContenido.Usuario.Email);

                        reporteContenido.Usuario.Reporte
                        .Add (reporteContenido);
                }
                if (reporteContenido.Contenido != null) {
                        // Argumento OID y no colección.
                        reporteContenido.Contenido = (YoureOnGenNHibernate.EN.YoureOn.ContenidoEN)session.Load (typeof(YoureOnGenNHibernate.EN.YoureOn.ContenidoEN), reporteContenido.Contenido.Id_contenido);

                        reporteContenido.Contenido.Reporte
                        .Add (reporteContenido);
                }

                session.Save (reporteContenido);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporteContenidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reporteContenido.Id_reporte;
}

public void Modify (ReporteContenidoEN reporteContenido)
{
        try
        {
                SessionInitializeTransaction ();
                ReporteContenidoEN reporteContenidoEN = (ReporteContenidoEN)session.Load (typeof(ReporteContenidoEN), reporteContenido.Id_reporte);
                session.Update (reporteContenidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporteContenidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id_reporte
                     )
{
        try
        {
                SessionInitializeTransaction ();
                ReporteContenidoEN reporteContenidoEN = (ReporteContenidoEN)session.Load (typeof(ReporteContenidoEN), id_reporte);
                session.Delete (reporteContenidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporteContenidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
