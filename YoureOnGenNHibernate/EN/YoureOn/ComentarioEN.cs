
using System;
// Definición clase ComentarioEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class ComentarioEN
{
/**
 *	Atributo id
 */
private string id;



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






public virtual string Id {
        get { return id; } set { id = value;  }
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





public ComentarioEN()
{
        valoracion_comentario = new System.Collections.Generic.List<YoureOnGenNHibernate.EN.YoureOn.ValoracionComentarioEN>();
}



public ComentarioEN(string id, string texto, Nullable<DateTime> fecha, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionComentarioEN> valoracion_comentario, YoureOnGenNHibernate.EN.YoureOn.ContenidoEN contenido
                    )
{
        this.init (Id, texto, fecha, usuario, valoracion_comentario, contenido);
}


public ComentarioEN(ComentarioEN comentario)
{
        this.init (Id, comentario.Texto, comentario.Fecha, comentario.Usuario, comentario.Valoracion_comentario, comentario.Contenido);
}

private void init (string id
                   , string texto, Nullable<DateTime> fecha, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionComentarioEN> valoracion_comentario, YoureOnGenNHibernate.EN.YoureOn.ContenidoEN contenido)
{
        this.Id = id;


        this.Texto = texto;

        this.Fecha = fecha;

        this.Usuario = usuario;

        this.Valoracion_comentario = valoracion_comentario;

        this.Contenido = contenido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ComentarioEN t = obj as ComentarioEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
