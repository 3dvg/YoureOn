

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

public int New_ (string p_titulo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum p_tipoArchivo, string p_descripcion, YoureOnGenNHibernate.Enumerated.YoureOn.TipoLicenciaEnum p_licencia, string p_usuario, string p_autor, bool p_enBiblioteca, string p_url, Nullable<DateTime> p_fechaCreacion, int p_duracion, int p_resolucion, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoVideoEnum p_formatoVideo)
{
        VideoEN videoEN = null;
        int oid;

        //Initialized VideoEN
        videoEN = new VideoEN ();
        videoEN.Titulo = p_titulo;

        videoEN.TipoArchivo = p_tipoArchivo;

        videoEN.Descripcion = p_descripcion;

        videoEN.Licencia = p_licencia;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id_contenido
                videoEN.Usuario = new YoureOnGenNHibernate.EN.YoureOn.UsuarioEN ();
                videoEN.Usuario.Email = p_usuario;
        }

        videoEN.Autor = p_autor;

        videoEN.EnBiblioteca = p_enBiblioteca;

        videoEN.Url = p_url;

        videoEN.FechaCreacion = p_fechaCreacion;

        videoEN.Duracion = p_duracion;

        videoEN.Resolucion = p_resolucion;

        videoEN.FormatoVideo = p_formatoVideo;

        //Call to VideoCAD

        oid = _IVideoCAD.New_ (videoEN);
        return oid;
}

public void Modify (int p_Video_OID, string p_titulo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum p_tipoArchivo, string p_descripcion, YoureOnGenNHibernate.Enumerated.YoureOn.TipoLicenciaEnum p_licencia, string p_autor, bool p_enBiblioteca, string p_url, Nullable<DateTime> p_fechaCreacion, int p_duracion, int p_resolucion, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoVideoEnum p_formatoVideo)
{
        VideoEN videoEN = null;

        //Initialized VideoEN
        videoEN = new VideoEN ();
        videoEN.Id_contenido = p_Video_OID;
        videoEN.Titulo = p_titulo;
        videoEN.TipoArchivo = p_tipoArchivo;
        videoEN.Descripcion = p_descripcion;
        videoEN.Licencia = p_licencia;
        videoEN.Autor = p_autor;
        videoEN.EnBiblioteca = p_enBiblioteca;
        videoEN.Url = p_url;
        videoEN.FechaCreacion = p_fechaCreacion;
        videoEN.Duracion = p_duracion;
        videoEN.Resolucion = p_resolucion;
        videoEN.FormatoVideo = p_formatoVideo;
        //Call to VideoCAD

        _IVideoCAD.Modify (videoEN);
}

public void Destroy (int id_contenido
                     )
{
        _IVideoCAD.Destroy (id_contenido);
}
}
}
