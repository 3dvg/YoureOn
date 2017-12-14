
using System;
// Definición clase AudioEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class AudioEN                                                                        : YoureOnGenNHibernate.EN.YoureOn.ContenidoEN


{
/**
 *	Atributo duracion
 */
private int duracion;



/**
 *	Atributo formatoAudio
 */
private YoureOnGenNHibernate.Enumerated.YoureOn.FormatoAudioEnum formatoAudio;






public virtual int Duracion {
        get { return duracion; } set { duracion = value;  }
}



public virtual YoureOnGenNHibernate.Enumerated.YoureOn.FormatoAudioEnum FormatoAudio {
        get { return formatoAudio; } set { formatoAudio = value;  }
}





public AudioEN() : base ()
{
}



public AudioEN(int id_contenido, int duracion, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoAudioEnum formatoAudio
               , string titulo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum tipoArchivo, string descripcion, string licencia, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, string autor, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionContenidoEN> valoracion_contenido, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN> biblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario, bool enBiblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporteContenidoEN> reporte, string url, Nullable<DateTime> fechaCreacion
               )
{
        this.init (Id_contenido, duracion, formatoAudio, titulo, tipoArchivo, descripcion, licencia, usuario, autor, valoracion_contenido, biblioteca, comentario, enBiblioteca, reporte, url, fechaCreacion);
}


public AudioEN(AudioEN audio)
{
        this.init (Id_contenido, audio.Duracion, audio.FormatoAudio, audio.Titulo, audio.TipoArchivo, audio.Descripcion, audio.Licencia, audio.Usuario, audio.Autor, audio.Valoracion_contenido, audio.Biblioteca, audio.Comentario, audio.EnBiblioteca, audio.Reporte, audio.Url, audio.FechaCreacion);
}

private void init (int id_contenido
                   , int duracion, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoAudioEnum formatoAudio, string titulo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum tipoArchivo, string descripcion, string licencia, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, string autor, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionContenidoEN> valoracion_contenido, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN> biblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario, bool enBiblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporteContenidoEN> reporte, string url, Nullable<DateTime> fechaCreacion)
{
        this.Id_contenido = id_contenido;


        this.Duracion = duracion;

        this.FormatoAudio = formatoAudio;

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
        AudioEN t = obj as AudioEN;
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
