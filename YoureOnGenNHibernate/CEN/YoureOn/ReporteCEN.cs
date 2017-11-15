

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
 *      Definition of the class ReporteCEN
 *
 */
public partial class ReporteCEN
{
private IReporteCAD _IReporteCAD;

public ReporteCEN()
{
        this._IReporteCAD = new ReporteCAD ();
}

public ReporteCEN(IReporteCAD _IReporteCAD)
{
        this._IReporteCAD = _IReporteCAD;
}

public IReporteCAD get_IReporteCAD ()
{
        return this._IReporteCAD;
}

public int New_ (string p_usuario)
{
        ReporteEN reporteEN = null;
        int oid;

        //Initialized ReporteEN
        reporteEN = new ReporteEN ();

        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id_reporte
                reporteEN.Usuario = new YoureOnGenNHibernate.EN.YoureOn.UsuarioEN ();
                reporteEN.Usuario.Email = p_usuario;
        }

        //Call to ReporteCAD

        oid = _IReporteCAD.New_ (reporteEN);
        return oid;
}

public void Modify (int p_Reporte_OID)
{
        ReporteEN reporteEN = null;

        //Initialized ReporteEN
        reporteEN = new ReporteEN ();
        reporteEN.Id_reporte = p_Reporte_OID;
        //Call to ReporteCAD

        _IReporteCAD.Modify (reporteEN);
}

public void Destroy (int id_reporte
                     )
{
        _IReporteCAD.Destroy (id_reporte);
}
}
}
