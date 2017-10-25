
using System;
// Definición clase ImagenEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class ImagenEN                                                                       : YoureOnGenNHibernate.EN.YoureOn.ContenidoEN


{
/**
 *	Atributo resolucion
 */
private int resolucion;



/**
 *	Atributo formatoImagen
 */
private YoureOnGenNHibernate.Enumerated.YoureOn.FormatoImagenEnum formatoImagen;






public virtual int Resolucion {
        get { return resolucion; } set { resolucion = value;  }
}



public virtual YoureOnGenNHibernate.Enumerated.YoureOn.FormatoImagenEnum FormatoImagen {
        get { return formatoImagen; } set { formatoImagen = value;  }
}





public ImagenEN() : base ()
{
}



public ImagenEN(string titulo, int resolucion, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoImagenEnum formatoImagen
                , YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum tipoArchivo, string descripcion, string licencia, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, string autor, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionContenidoEN> valoracion_contenido, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN> biblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario, bool enBiblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporeteContenidoEN> reporte
                )
{
        this.init (Titulo, resolucion, formatoImagen, tipoArchivo, descripcion, licencia, usuario, autor, valoracion_contenido, biblioteca, comentario, enBiblioteca, reporte);
}


public ImagenEN(ImagenEN imagen)
{
        this.init (Titulo, imagen.Resolucion, imagen.FormatoImagen, imagen.TipoArchivo, imagen.Descripcion, imagen.Licencia, imagen.Usuario, imagen.Autor, imagen.Valoracion_contenido, imagen.Biblioteca, imagen.Comentario, imagen.EnBiblioteca, imagen.Reporte);
}

private void init (string titulo
                   , int resolucion, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoImagenEnum formatoImagen, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum tipoArchivo, string descripcion, string licencia, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, string autor, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionContenidoEN> valoracion_contenido, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN> biblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario, bool enBiblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporeteContenidoEN> reporte)
{
        this.Titulo = titulo;


        this.Resolucion = resolucion;

        this.FormatoImagen = formatoImagen;

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
        ImagenEN t = obj as ImagenEN;
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
