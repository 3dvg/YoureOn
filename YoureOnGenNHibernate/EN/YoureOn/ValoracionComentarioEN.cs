
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



public ValoracionComentarioEN(int id_valoracion, YoureOnGenNHibernate.EN.YoureOn.ComentarioEN comentario
                              , Nullable<DateTime> fecha, int nota
                              )
{
        this.init (Id_valoracion, comentario, fecha, nota);
}


public ValoracionComentarioEN(ValoracionComentarioEN valoracionComentario)
{
        this.init (Id_valoracion, valoracionComentario.Comentario, valoracionComentario.Fecha, valoracionComentario.Nota);
}

private void init (int id_valoracion
                   , YoureOnGenNHibernate.EN.YoureOn.ComentarioEN comentario, Nullable<DateTime> fecha, int nota)
{
        this.Id_valoracion = id_valoracion;


        this.Comentario = comentario;

        this.Fecha = fecha;

        this.Nota = nota;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ValoracionComentarioEN t = obj as ValoracionComentarioEN;
        if (t == null)
                return false;
        if (Id_valoracion.Equals (t.Id_valoracion))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id_valoracion.GetHashCode ();
        return hash;
}
}
}
