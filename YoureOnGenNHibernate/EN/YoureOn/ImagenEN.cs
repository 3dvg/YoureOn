
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



public ImagenEN(int id_contenido, int resolucion, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoImagenEnum formatoImagen
                , string titulo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum tipoArchivo, string descripcion, string licencia, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, string autor, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionContenidoEN> valoracion_contenido, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN> biblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario, bool enBiblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporteContenidoEN> reporte
                )
{
        this.init (Id_contenido, resolucion, formatoImagen, titulo, tipoArchivo, descripcion, licencia, usuario, autor, valoracion_contenido, biblioteca, comentario, enBiblioteca, reporte);
}


public ImagenEN(ImagenEN imagen)
{
        this.init (Id_contenido, imagen.Resolucion, imagen.FormatoImagen, imagen.Titulo, imagen.TipoArchivo, imagen.Descripcion, imagen.Licencia, imagen.Usuario, imagen.Autor, imagen.Valoracion_contenido, imagen.Biblioteca, imagen.Comentario, imagen.EnBiblioteca, imagen.Reporte);
}

private void init (int id_contenido
                   , int resolucion, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoImagenEnum formatoImagen, string titulo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum tipoArchivo, string descripcion, string licencia, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, string autor, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionContenidoEN> valoracion_contenido, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN> biblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario, bool enBiblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporteContenidoEN> reporte)
{
        this.Id_contenido = id_contenido;


        this.Resolucion = resolucion;

        this.FormatoImagen = formatoImagen;

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
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ImagenEN t = obj as ImagenEN;
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
