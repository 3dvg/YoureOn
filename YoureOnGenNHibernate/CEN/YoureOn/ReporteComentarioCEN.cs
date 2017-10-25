

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

public int New_ (string p_usuario)
{
        ReporteComentarioEN reporteComentarioEN = null;
        int oid;

        //Initialized ReporteComentarioEN
        reporteComentarioEN = new ReporteComentarioEN ();

        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                reporteComentarioEN.Usuario = new YoureOnGenNHibernate.EN.YoureOn.UsuarioEN ();
                reporteComentarioEN.Usuario.Email = p_usuario;
        }

        //Call to ReporteComentarioCAD

        oid = _IReporteComentarioCAD.New_ (reporteComentarioEN);
        return oid;
}

public void Modify (int p_ReporteComentario_OID)
{
        ReporteComentarioEN reporteComentarioEN = null;

        //Initialized ReporteComentarioEN
        reporteComentarioEN = new ReporteComentarioEN ();
        reporteComentarioEN.Id = p_ReporteComentario_OID;
        //Call to ReporteComentarioCAD

        _IReporteComentarioCAD.Modify (reporteComentarioEN);
}

public void Destroy (int id
                     )
{
        _IReporteComentarioCAD.Destroy (id);
}
}
}
