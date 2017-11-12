
using System;
// Definición clase ContenidoEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class ContenidoEN
{
/**
 *	Atributo titulo
 */
private string titulo;

        /*
         *  Atributo Puntuacion Final
         */
        private int puntuacionFinal;

        /*
         *  Atributo Numero de votos  
         */
        private int numeroDeVotos;

        /*
         *  Atributo Numero de votos  
         */
        private int puntuacionIndividual;

        /**
         *	Atributo tipoArchivo
         */
        private YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum tipoArchivo;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo licencia
 */
private string licencia;



/**
 *	Atributo usuario
 */
private YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario;



/**
 *	Atributo autor
 */
private string autor;



/**
 *	Atributo valoracion_contenido
 */
private System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionContenidoEN> valoracion_contenido;



/**
 *	Atributo biblioteca
 */
private System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN> biblioteca;



/**
 *	Atributo comentario
 */
private System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario;



/**
 *	Atributo enBiblioteca
 */
private bool enBiblioteca;



/**
 *	Atributo reporte
 */
private System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporeteContenidoEN> reporte;






public virtual string Titulo {
        get { return titulo; } set { titulo = value;  }
}

public virtual string PuntuacionFinal {
        get { return puntuacionFinal; } set { puntuacionFinal = value;  }
        }

public virtual string PuntuacionIndividual {
        get { return puntuacionIndividual; } set { puntuacionIndividual = value;  }
        }
public virtual string NumeroDeVotos {
            get { return numeroDeVotos; } set { numeroDeVotos = value;  }
        }

        public virtual YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum TipoArchivo {
        get { return tipoArchivo; } set { tipoArchivo = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual string Licencia {
        get { return licencia; } set { licencia = value;  }
}



public virtual YoureOnGenNHibernate.EN.YoureOn.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual string Autor {
        get { return autor; } set { autor = value;  }
}



public virtual System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionContenidoEN> Valoracion_contenido {
        get { return valoracion_contenido; } set { valoracion_contenido = value;  }
}



public virtual System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN> Biblioteca {
        get { return biblioteca; } set { biblioteca = value;  }
}



public virtual System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual bool EnBiblioteca {
        get { return enBiblioteca; } set { enBiblioteca = value;  }
}



public virtual System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporeteContenidoEN> Reporte {
        get { return reporte; } set { reporte = value;  }
}





public ContenidoEN()
{
        valoracion_contenido = new System.Collections.Generic.List<YoureOnGenNHibernate.EN.YoureOn.ValoracionContenidoEN>();
        biblioteca = new System.Collections.Generic.List<YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN>();
        comentario = new System.Collections.Generic.List<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN>();
        reporte = new System.Collections.Generic.List<YoureOnGenNHibernate.EN.YoureOn.ReporeteContenidoEN>();
}



public ContenidoEN(string titulo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum tipoArchivo, string descripcion, string licencia, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, string autor, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionContenidoEN> valoracion_contenido, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN> biblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario, bool enBiblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporeteContenidoEN> reporte
                   )
{
        this.init (Titulo, tipoArchivo, descripcion, licencia, usuario, autor, valoracion_contenido, biblioteca, comentario, enBiblioteca, reporte);
}


public ContenidoEN(ContenidoEN contenido)
{
        this.init (Titulo, contenido.TipoArchivo, contenido.Descripcion, contenido.Licencia, contenido.Usuario, contenido.Autor, contenido.Valoracion_contenido, contenido.Biblioteca, contenido.Comentario, contenido.EnBiblioteca, contenido.Reporte);
}

private void init (string titulo
                   , YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum tipoArchivo, string descripcion, string licencia, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, string autor, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionContenidoEN> valoracion_contenido, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN> biblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario, bool enBiblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporeteContenidoEN> reporte)
{
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
        ContenidoEN t = obj as ContenidoEN;
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
