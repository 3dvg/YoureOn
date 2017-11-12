
using System;
// Definición clase ValoracionComentarioEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class ValoracionComentarioEN                                                                 : YoureOnGenNHibernate.EN.YoureOn.ValoracionEN


{
/**
 *	Atributo comentario
 */
private YoureOnGenNHibernate.EN.YoureOn.ComentarioEN comentario;






public virtual YoureOnGenNHibernate.EN.YoureOn.ComentarioEN Comentario {
        get { return comentario; } set { comentario = value;  }
}





public ValoracionComentarioEN() : base ()
{
}



public ValoracionComentarioEN(string id, YoureOnGenNHibernate.EN.YoureOn.ComentarioEN comentario
                              , Nullable<DateTime> fecha, float nota, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.UsuarioEN> usuario
                              )
{
        this.init (Id, comentario, fecha, nota, usuario);
}


public ValoracionComentarioEN(ValoracionComentarioEN valoracionComentario)
{
        this.init (Id, valoracionComentario.Comentario, valoracionComentario.Fecha, valoracionComentario.Nota, valoracionComentario.Usuario);
}

private void init (string id
                   , YoureOnGenNHibernate.EN.YoureOn.ComentarioEN comentario, Nullable<DateTime> fecha, float nota, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.UsuarioEN> usuario)
{
        this.Id = id;


        this.Comentario = comentario;

        this.Fecha = fecha;

        this.Nota = nota;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ValoracionComentarioEN t = obj as ValoracionComentarioEN;
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
