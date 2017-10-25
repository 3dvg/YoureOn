
using System;
// Definición clase VideoEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class VideoEN                                                                        : YoureOnGenNHibernate.EN.YoureOn.ContenidoEN


{
/**
 *	Atributo duracion
 */
private Nullable<DateTime> duracion;



/**
 *	Atributo resolucion
 */
private int resolucion;



/**
 *	Atributo formatoVideo
 */
private YoureOnGenNHibernate.Enumerated.YoureOn.FormatoVideoEnum formatoVideo;






public virtual Nullable<DateTime> Duracion {
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



public VideoEN(string titulo, Nullable<DateTime> duracion, int resolucion, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoVideoEnum formatoVideo
               , YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum tipoArchivo, string descripcion, string licencia, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, string autor, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionContenidoEN> valoracion_contenido, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN> biblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario, bool enBiblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporeteContenidoEN> reporte
               )
{
        this.init (Titulo, duracion, resolucion, formatoVideo, tipoArchivo, descripcion, licencia, usuario, autor, valoracion_contenido, biblioteca, comentario, enBiblioteca, reporte);
}


public VideoEN(VideoEN video)
{
        this.init (Titulo, video.Duracion, video.Resolucion, video.FormatoVideo, video.TipoArchivo, video.Descripcion, video.Licencia, video.Usuario, video.Autor, video.Valoracion_contenido, video.Biblioteca, video.Comentario, video.EnBiblioteca, video.Reporte);
}

private void init (string titulo
                   , Nullable<DateTime> duracion, int resolucion, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoVideoEnum formatoVideo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum tipoArchivo, string descripcion, string licencia, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, string autor, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionContenidoEN> valoracion_contenido, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN> biblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario, bool enBiblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporeteContenidoEN> reporte)
{
        this.Titulo = titulo;


        this.Duracion = duracion;

        this.Resolucion = resolucion;

        this.FormatoVideo = formatoVideo;

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
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        VideoEN t = obj as VideoEN;
        if (t == null)
                return false;
        if (Titulo.Equals (t.Titulo))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Titulo.GetHashCode ();
        return hash;
}
}
}
