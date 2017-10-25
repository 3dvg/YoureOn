

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
 *      Definition of the class ReporeteContenidoCEN
 *
 */
public partial class ReporeteContenidoCEN
{
private IReporeteContenidoCAD _IReporeteContenidoCAD;

public ReporeteContenidoCEN()
{
        this._IReporeteContenidoCAD = new ReporeteContenidoCAD ();
}

public ReporeteContenidoCEN(IReporeteContenidoCAD _IReporeteContenidoCAD)
{
        this._IReporeteContenidoCAD = _IReporeteContenidoCAD;
}

public IReporeteContenidoCAD get_IReporeteContenidoCAD ()
{
        return this._IReporeteContenidoCAD;
}

public int New_ (string p_usuario, string p_contenido)
{
        ReporeteContenidoEN reporeteContenidoEN = null;
        int oid;

        //Initialized ReporeteContenidoEN
        reporeteContenidoEN = new ReporeteContenidoEN ();

        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                reporeteContenidoEN.Usuario = new YoureOnGenNHibernate.EN.YoureOn.UsuarioEN ();
                reporeteContenidoEN.Usuario.Email = p_usuario;
        }


        if (p_contenido != null) {
                // El argumento p_contenido -> Property contenido es oid = false
                // Lista de oids id
                reporeteContenidoEN.Contenido = new YoureOnGenNHibernate.EN.YoureOn.ContenidoEN ();
                reporeteContenidoEN.Contenido.Titulo = p_contenido;
        }

        //Call to ReporeteContenidoCAD

        oid = _IReporeteContenidoCAD.New_ (reporeteContenidoEN);
        return oid;
}

public void Modify (int p_ReporeteContenido_OID)
{
        ReporeteContenidoEN reporeteContenidoEN = null;

        //Initialized ReporeteContenidoEN
        reporeteContenidoEN = new ReporeteContenidoEN ();
        reporeteContenidoEN.Id = p_ReporeteContenido_OID;
        //Call to ReporeteContenidoCAD

        _IReporeteContenidoCAD.Modify (reporeteContenidoEN);
}

public void Destroy (int id
                     )
{
        _IReporeteContenidoCAD.Destroy (id);
}
}
}
