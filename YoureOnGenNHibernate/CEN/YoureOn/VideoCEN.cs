

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
 *      Definition of the class VideoCEN
 *
 */
public partial class VideoCEN
{
private IVideoCAD _IVideoCAD;

public VideoCEN()
{
        this._IVideoCAD = new VideoCAD ();
}

public VideoCEN(IVideoCAD _IVideoCAD)
{
        this._IVideoCAD = _IVideoCAD;
}

public IVideoCAD get_IVideoCAD ()
{
        return this._IVideoCAD;
}

public string New_ (string p_titulo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum p_tipoArchivo, string p_descripcion, string p_licencia, string p_usuario, string p_autor, bool p_enBiblioteca, Nullable<DateTime> p_duracion, int p_resolucion, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoVideoEnum p_formatoVideo)
{
        VideoEN videoEN = null;
        string oid;

        //Initialized VideoEN
        videoEN = new VideoEN ();
        videoEN.Titulo = p_titulo;

        videoEN.TipoArchivo = p_tipoArchivo;

        videoEN.Descripcion = p_descripcion;

        videoEN.Licencia = p_licencia;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids titulo
                videoEN.Usuario = new YoureOnGenNHibernate.EN.YoureOn.UsuarioEN ();
                videoEN.Usuario.Email = p_usuario;
        }

        videoEN.Autor = p_autor;

        videoEN.EnBiblioteca = p_enBiblioteca;

        videoEN.Duracion = p_duracion;

        videoEN.Resolucion = p_resolucion;

        videoEN.FormatoVideo = p_formatoVideo;

        //Call to VideoCAD

        oid = _IVideoCAD.New_ (videoEN);
        return oid;
}

public void Modify (string p_Video_OID, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum p_tipoArchivo, string p_descripcion, string p_licencia, string p_autor, bool p_enBiblioteca, Nullable<DateTime> p_duracion, int p_resolucion, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoVideoEnum p_formatoVideo)
{
        VideoEN videoEN = null;

        //Initialized VideoEN
        videoEN = new VideoEN ();
        videoEN.Titulo = p_Video_OID;
        videoEN.TipoArchivo = p_tipoArchivo;
        videoEN.Descripcion = p_descripcion;
        videoEN.Licencia = p_licencia;
        videoEN.Autor = p_autor;
        videoEN.EnBiblioteca = p_enBiblioteca;
        videoEN.Duracion = p_duracion;
        videoEN.Resolucion = p_resolucion;
        videoEN.FormatoVideo = p_formatoVideo;
        //Call to VideoCAD

        _IVideoCAD.Modify (videoEN);
}

public void Destroy (string titulo
                     )
{
        _IVideoCAD.Destroy (titulo);
}
}
}
