
using System;
// Definición clase ReporeteContenidoEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class ReporeteContenidoEN                                                                    : YoureOnGenNHibernate.EN.YoureOn.ReporteEN


{
/**
 *	Atributo contenido
 */
private YoureOnGenNHibernate.EN.YoureOn.ContenidoEN contenido;






public virtual YoureOnGenNHibernate.EN.YoureOn.ContenidoEN Contenido {
        get { return contenido; } set { contenido = value;  }
}





public ReporeteContenidoEN() : base ()
{
}



public ReporeteContenidoEN(int id, YoureOnGenNHibernate.EN.YoureOn.ContenidoEN contenido
                           , YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario
                           )
{
        this.init (Id, contenido, usuario);
}


public ReporeteContenidoEN(ReporeteContenidoEN reporeteContenido)
{
        this.init (Id, reporeteContenido.Contenido, reporeteContenido.Usuario);
}

private void init (int id
                   , YoureOnGenNHibernate.EN.YoureOn.ContenidoEN contenido, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario)
{
        this.Id = id;


        this.Contenido = contenido;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ReporeteContenidoEN t = obj as ReporeteContenidoEN;
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
