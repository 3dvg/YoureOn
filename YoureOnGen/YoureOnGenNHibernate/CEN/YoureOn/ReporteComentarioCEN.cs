

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
 *      Definition of the class ReporteComentarioCEN
 *
 */
public partial class ReporteComentarioCEN
{
private IReporteComentarioCAD _IReporteComentarioCAD;

public ReporteComentarioCEN()
{
        this._IReporteComentarioCAD = new ReporteComentarioCAD ();
}

public ReporteComentarioCEN(IReporteComentarioCAD _IReporteComentarioCAD)
{
        this._IReporteComentarioCAD = _IReporteComentarioCAD;
}

public IReporteComentarioCAD get_IReporteComentarioCAD ()
{
        return this._IReporteComentarioCAD;
}

public int New_ (Nullable<DateTime> p_fecha, int p_comentario)
{
        ReporteComentarioEN reporteComentarioEN = null;
        int oid;

        //Initialized ReporteComentarioEN
        reporteComentarioEN = new ReporteComentarioEN ();
        reporteComentarioEN.Fecha = p_fecha;


        if (p_comentario != -1) {
                // El argumento p_comentario -> Property comentario es oid = false
                // Lista de oids id_reporte
                reporteComentarioEN.Comentario = new YoureOnGenNHibernate.EN.YoureOn.ComentarioEN ();
                reporteComentarioEN.Comentario.Id_comentario = p_comentario;
        }

        //Call to ReporteComentarioCAD

        oid = _IReporteComentarioCAD.New_ (reporteComentarioEN);
        return oid;
}

public void Modify (int p_ReporteComentario_OID, Nullable<DateTime> p_fecha)
{
        ReporteComentarioEN reporteComentarioEN = null;

        //Initialized ReporteComentarioEN
        reporteComentarioEN = new ReporteComentarioEN ();
        reporteComentarioEN.Id_reporte = p_ReporteComentario_OID;
        reporteComentarioEN.Fecha = p_fecha;
        //Call to ReporteComentarioCAD

        _IReporteComentarioCAD.Modify (reporteComentarioEN);
}

public void Destroy (int id_reporte
                     )
{
        _IReporteComentarioCAD.Destroy (id_reporte);
}
}
}
