

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
 *      Definition of the class ContenidoCEN
 *
 */
public partial class ContenidoCEN
{
private IContenidoCAD _IContenidoCAD;

public ContenidoCEN()
{
        this._IContenidoCAD = new ContenidoCAD ();
}

public ContenidoCEN(IContenidoCAD _IContenidoCAD)
{
        this._IContenidoCAD = _IContenidoCAD;
}

public IContenidoCAD get_IContenidoCAD ()
{
        return this._IContenidoCAD;
}

public int SubirContenido (string p_titulo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum p_tipoArchivo, string p_descripcion, string p_licencia, string p_usuario, string p_autor, bool p_enBiblioteca, string p_url, Nullable<DateTime> p_fechaCreacion)
{
        ContenidoEN contenidoEN = null;
        int oid;

        //Initialized ContenidoEN
        contenidoEN = new ContenidoEN ();
        contenidoEN.Titulo = p_titulo;

        contenidoEN.TipoArchivo = p_tipoArchivo;

        contenidoEN.Descripcion = p_descripcion;

        contenidoEN.Licencia = p_licencia;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id_contenido
                contenidoEN.Usuario = new YoureOnGenNHibernate.EN.YoureOn.UsuarioEN ();
                contenidoEN.Usuario.Email = p_usuario;
        }

        contenidoEN.Autor = p_autor;

        contenidoEN.EnBiblioteca = p_enBiblioteca;

        contenidoEN.Url = p_url;

        contenidoEN.FechaCreacion = p_fechaCreacion;

        //Call to ContenidoCAD

        oid = _IContenidoCAD.SubirContenido (contenidoEN);
        return oid;
}

public void Editar (int p_Contenido_OID, string p_titulo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum p_tipoArchivo, string p_descripcion, string p_licencia, string p_autor, bool p_enBiblioteca, string p_url, Nullable<DateTime> p_fechaCreacion)
{
        ContenidoEN contenidoEN = null;

        //Initialized ContenidoEN
        contenidoEN = new ContenidoEN ();
        contenidoEN.Id_contenido = p_Contenido_OID;
        contenidoEN.Titulo = p_titulo;
        contenidoEN.TipoArchivo = p_tipoArchivo;
        contenidoEN.Descripcion = p_descripcion;
        contenidoEN.Licencia = p_licencia;
        contenidoEN.Autor = p_autor;
        contenidoEN.EnBiblioteca = p_enBiblioteca;
        contenidoEN.Url = p_url;
        contenidoEN.FechaCreacion = p_fechaCreacion;
        //Call to ContenidoCAD

        _IContenidoCAD.Editar (contenidoEN);
}

public void Borrar (int id_contenido
                    )
{
        _IContenidoCAD.Borrar (id_contenido);
}

public ContenidoEN CargarContenido (int id_contenido
                                    )
{
        ContenidoEN contenidoEN = null;

        contenidoEN = _IContenidoCAD.CargarContenido (id_contenido);
        return contenidoEN;
}

public System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> DameContenidoPorTitulo (string c_titulo)
{
        return _IContenidoCAD.DameContenidoPorTitulo (c_titulo);
}
}
}
