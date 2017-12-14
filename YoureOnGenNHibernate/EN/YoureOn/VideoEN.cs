
using System;
// Definición clase VideoEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class VideoEN                                                                        : YoureOnGenNHibernate.EN.YoureOn.ContenidoEN


{
/**
 *	Atributo duracion
 */
private int duracion;



/**
 *	Atributo resolucion
 */
private int resolucion;



/**
 *	Atributo formatoVideo
 */
private YoureOnGenNHibernate.Enumerated.YoureOn.FormatoVideoEnum formatoVideo;






public virtual int Duracion {
        get { return duracion; } set { duracion = value;  }
}



public virtual int Resolucion {
        get { return resolucion; } set { resolucion = value;  }
}



public virtual YoureOnGenNHibernate.Enumerated.YoureOn.FormatoVideoEnum FormatoVideo {
        get { return formatoVideo; } set { formatoVideo = value;  }
}





public VideoEN() : base ()
{
}



public VideoEN(int id_contenido, int duracion, int resolucion, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoVideoEnum formatoVideo
               , string titulo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum tipoArchivo, string descripcion, string licencia, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, string autor, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionContenidoEN> valoracion_contenido, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN> biblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario, bool enBiblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporteContenidoEN> reporte, string url, Nullable<DateTime> fechaCreacion
               )
{
        this.init (Id_contenido, duracion, resolucion, formatoVideo, titulo, tipoArchivo, descripcion, licencia, usuario, autor, valoracion_contenido, biblioteca, comentario, enBiblioteca, reporte, url, fechaCreacion);
}


public VideoEN(VideoEN video)
{
        this.init (Id_contenido, video.Duracion, video.Resolucion, video.FormatoVideo, video.Titulo, video.TipoArchivo, video.Descripcion, video.Licencia, video.Usuario, video.Autor, video.Valoracion_contenido, video.Biblioteca, video.Comentario, video.EnBiblioteca, video.Reporte, video.Url, video.FechaCreacion);
}

private void init (int id_contenido
                   , int duracion, int resolucion, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoVideoEnum formatoVideo, string titulo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum tipoArchivo, string descripcion, string licencia, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, string autor, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionContenidoEN> valoracion_contenido, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN> biblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario, bool enBiblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporteContenidoEN> reporte, string url, Nullable<DateTime> fechaCreacion)
{
        this.Id_contenido = id_contenido;


        this.Duracion = duracion;

        this.Resolucion = resolucion;

        this.FormatoVideo = formatoVideo;

        this.Titulo = titulo;

        this.TipoArchivo = tipoArchivo;

        this.Descripcion = descripcion;

        this.Licencia = licencia;

        this.Usuario = usuario;

        this.Autor = autor;

        this.Valoracion_contenido = valoracion_contenido;

        this.Biblioteca = biblioteca;

        this.Comentario = comentario;

        this.EnBiblioteca = enBiblioteca;

        this.Reporte = reporte;

        this.Url = url;

        this.FechaCreacion = fechaCreacion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        VideoEN t = obj as VideoEN;
        if (t == null)
                return false;
        if (Id_contenido.Equals (t.Id_contenido))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id_contenido.GetHashCode ();
        return hash;
}
}
}
