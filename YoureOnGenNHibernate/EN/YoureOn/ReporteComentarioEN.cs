
using System;
// Definición clase ReporteComentarioEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class ReporteComentarioEN                                                                    : YoureOnGenNHibernate.EN.YoureOn.ReporteEN


{
/**
 *	Atributo comentario
 */
private YoureOnGenNHibernate.EN.YoureOn.ComentarioEN comentario;






public virtual YoureOnGenNHibernate.EN.YoureOn.ComentarioEN Comentario {
        get { return comentario; } set { comentario = value;  }
}





public ReporteComentarioEN() : base ()
{
}



public ReporteComentarioEN(int id_reporte, YoureOnGenNHibernate.EN.YoureOn.ComentarioEN comentario
                           , YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario
                           )
{
        this.init (Id_reporte, comentario, usuario);
}


public ReporteComentarioEN(ReporteComentarioEN reporteComentario)
{
        this.init (Id_reporte, reporteComentario.Comentario, reporteComentario.Usuario);
}

private void init (int id_reporte
                   , YoureOnGenNHibernate.EN.YoureOn.ComentarioEN comentario, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario)
{
        this.Id_reporte = id_reporte;


        this.Comentario = comentario;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ReporteComentarioEN t = obj as ReporteComentarioEN;
        if (t == null)
                return false;
        if (Id_reporte.Equals (t.Id_reporte))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id_reporte.GetHashCode ();
        return hash;
}
}
}
