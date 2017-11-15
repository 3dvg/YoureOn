
using System;
// Definición clase TextoEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class TextoEN                                                                        : YoureOnGenNHibernate.EN.YoureOn.ContenidoEN


{
/**
 *	Atributo numeroPaginas
 */
private int numeroPaginas;






public virtual int NumeroPaginas {
        get { return numeroPaginas; } set { numeroPaginas = value;  }
}





public TextoEN() : base ()
{
}



public TextoEN(int id_contenido, int numeroPaginas
               , string titulo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum tipoArchivo, string descripcion, string licencia, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, string autor, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionContenidoEN> valoracion_contenido, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN> biblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario, bool enBiblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporteContenidoEN> reporte
               )
{
        this.init (Id_contenido, numeroPaginas, titulo, tipoArchivo, descripcion, licencia, usuario, autor, valoracion_contenido, biblioteca, comentario, enBiblioteca, reporte);
}


public TextoEN(TextoEN texto)
{
        this.init (Id_contenido, texto.NumeroPaginas, texto.Titulo, texto.TipoArchivo, texto.Descripcion, texto.Licencia, texto.Usuario, texto.Autor, texto.Valoracion_contenido, texto.Biblioteca, texto.Comentario, texto.EnBiblioteca, texto.Reporte);
}

private void init (int id_contenido
                   , int numeroPaginas, string titulo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum tipoArchivo, string descripcion, string licencia, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, string autor, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionContenidoEN> valoracion_contenido, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN> biblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario, bool enBiblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporteContenidoEN> reporte)
{
        this.Id_contenido = id_contenido;


        this.NumeroPaginas = numeroPaginas;

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
        TextoEN t = obj as TextoEN;
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
