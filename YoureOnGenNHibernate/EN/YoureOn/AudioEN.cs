
using System;
// Definición clase AudioEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class AudioEN                                                                        : YoureOnGenNHibernate.EN.YoureOn.ContenidoEN


{
/**
 *	Atributo duracion
 */
private Nullable<DateTime> duracion;



/**
 *	Atributo formatoAudio
 */
private YoureOnGenNHibernate.Enumerated.YoureOn.FormatoAudioEnum formatoAudio;






public virtual Nullable<DateTime> Duracion {
        get { return duracion; } set { duracion = value;  }
}



public virtual YoureOnGenNHibernate.Enumerated.YoureOn.FormatoAudioEnum FormatoAudio {
        get { return formatoAudio; } set { formatoAudio = value;  }
}





public AudioEN() : base ()
{
}



public AudioEN(string titulo, Nullable<DateTime> duracion, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoAudioEnum formatoAudio
               , YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum tipoArchivo, string descripcion, string licencia, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, string autor, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionContenidoEN> valoracion_contenido, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN> biblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario, bool enBiblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporeteContenidoEN> reporte
               )
{
        this.init (Titulo, duracion, formatoAudio, tipoArchivo, descripcion, licencia, usuario, autor, valoracion_contenido, biblioteca, comentario, enBiblioteca, reporte);
}


public AudioEN(AudioEN audio)
{
        this.init (Titulo, audio.Duracion, audio.FormatoAudio, audio.TipoArchivo, audio.Descripcion, audio.Licencia, audio.Usuario, audio.Autor, audio.Valoracion_contenido, audio.Biblioteca, audio.Comentario, audio.EnBiblioteca, audio.Reporte);
}

private void init (string titulo
                   , Nullable<DateTime> duracion, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoAudioEnum formatoAudio, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum tipoArchivo, string descripcion, string licencia, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, string autor, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionContenidoEN> valoracion_contenido, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN> biblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario, bool enBiblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporeteContenidoEN> reporte)
{
        this.Titulo = titulo;


        this.Duracion = duracion;

        this.FormatoAudio = formatoAudio;

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
        AudioEN t = obj as AudioEN;
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