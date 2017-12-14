
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
 * Clase Reporte:
 *
 */

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial class ReporteCAD : BasicCAD, IReporteCAD
{
public ReporteCAD() : base ()
{
}

public ReporteCAD(ISession sessionAux) : base (sessionAux)
{
}



public ReporteEN ReadOIDDefault (int id_reporte
                                 )
{
        ReporteEN reporteEN = null;

        try
        {
                SessionInitializeTransaction ();
                reporteEN = (ReporteEN)session.Get (typeof(ReporteEN), id_reporte);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reporteEN;
}

public System.Collections.Generic.IList<ReporteEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ReporteEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ReporteEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ReporteEN>();
                        else
                                result = session.CreateCriteria (typeof(ReporteEN)).List<ReporteEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ReporteEN reporte)
{
        try
        {
                SessionInitializeTransaction ();
                ReporteEN reporteEN = (ReporteEN)session.Load (typeof(ReporteEN), reporte.Id_reporte);

                reporteEN.Fecha = reporte.Fecha;

                session.Update (reporteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ReporteEN reporte)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (reporte);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reporte.Id_reporte;
}

public void Modify (ReporteEN reporte)
{
        try
        {
                SessionInitializeTransaction ();
                ReporteEN reporteEN = (ReporteEN)session.Load (typeof(ReporteEN), reporte.Id_reporte);

                reporteEN.Fecha = reporte.Fecha;

                session.Update (reporteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
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
                ReporteEN reporteEN = (ReporteEN)session.Load (typeof(ReporteEN), id_reporte);
                session.Delete (reporteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
