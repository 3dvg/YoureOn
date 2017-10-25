
using System;
// Definición clase ReporteComentarioEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class ReporteComentarioEN                                                                    : YoureOnGenNHibernate.EN.YoureOn.ReporteEN


{
public ReporteComentarioEN() : base ()
{
}



public ReporteComentarioEN(int id,
                           YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario
                           )
{
        this.init (Id, usuario);
}


public ReporteComentarioEN(ReporteComentarioEN reporteComentario)
{
        this.init (Id, reporteComentario.Usuario);
}

private void init (int id
                   , YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario)
{
        this.Id = id;


        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ReporteComentarioEN t = obj as ReporteComentarioEN;
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
