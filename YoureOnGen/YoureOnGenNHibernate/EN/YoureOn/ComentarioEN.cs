
using System;
// Definición clase ComentarioEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class ComentarioEN
{
/**
 *	Atributo id_comentario
 */
private int id_comentario;



/**
 *	Atributo texto
 */
private string texto;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo usuario
 */
private YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario;



/**
 *	Atributo valoracion_comentario
 */
private System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionComentarioEN> valoracion_comentario;



/**
 *	Atributo contenido
 */
private YoureOnGenNHibernate.EN.YoureOn.ContenidoEN contenido;



/**
 *	Atributo reporteComentario
 */
private System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporteComentarioEN> reporteComentario;






public virtual int Id_comentario {
        get { return id_comentario; } set { id_comentario = value;  }
}



public virtual string Texto {
        get { return texto; } set { texto = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual YoureOnGenNHibernate.EN.YoureOn.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionComentarioEN> Valoracion_comentario {
        get { return valoracion_comentario; } set { valoracion_comentario = value;  }
}



public virtual YoureOnGenNHibernate.EN.YoureOn.ContenidoEN Contenido {
        get { return contenido; } set { contenido = value;  }
}



public virtual System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporteComentarioEN> ReporteComentario {
        get { return reporteComentario; } set { reporteComentario = value;  }
}





public ComentarioEN()
{
        valoracion_comentario = new System.Collections.Generic.List<YoureOnGenNHibernate.EN.YoureOn.ValoracionComentarioEN>();
        reporteComentario = new System.Collections.Generic.List<YoureOnGenNHibernate.EN.YoureOn.ReporteComentarioEN>();
}



public ComentarioEN(int id_comentario, string texto, Nullable<DateTime> fecha, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionComentarioEN> valoracion_comentario, YoureOnGenNHibernate.EN.YoureOn.ContenidoEN contenido, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporteComentarioEN> reporteComentario
                    )
{
        this.init (Id_comentario, texto, fecha, usuario, valoracion_comentario, contenido, reporteComentario);
}


public ComentarioEN(ComentarioEN comentario)
{
        this.init (Id_comentario, comentario.Texto, comentario.Fecha, comentario.Usuario, comentario.Valoracion_comentario, comentario.Contenido, comentario.ReporteComentario);
}

private void init (int id_comentario
                   , string texto, Nullable<DateTime> fecha, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionComentarioEN> valoracion_comentario, YoureOnGenNHibernate.EN.YoureOn.ContenidoEN contenido, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporteComentarioEN> reporteComentario)
{
        this.Id_comentario = id_comentario;


        this.Texto = texto;

        this.Fecha = fecha;

        this.Usuario = usuario;

        this.Valoracion_comentario = valoracion_comentario;

        this.Contenido = contenido;

        this.ReporteComentario = reporteComentario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ComentarioEN t = obj as ComentarioEN;
        if (t == null)
                return false;
        if (Id_comentario.Equals (t.Id_comentario))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id_comentario.GetHashCode ();
        return hash;
}
}
}
