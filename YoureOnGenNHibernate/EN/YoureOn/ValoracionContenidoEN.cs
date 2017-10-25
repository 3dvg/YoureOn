
using System;
// Definición clase ValoracionContenidoEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class ValoracionContenidoEN                                                                  : YoureOnGenNHibernate.EN.YoureOn.ValoracionEN


{
/**
 *	Atributo contenido
 */
private YoureOnGenNHibernate.EN.YoureOn.ContenidoEN contenido;






public virtual YoureOnGenNHibernate.EN.YoureOn.ContenidoEN Contenido {
        get { return contenido; } set { contenido = value;  }
}





public ValoracionContenidoEN() : base ()
{
}



public ValoracionContenidoEN(string id, YoureOnGenNHibernate.EN.YoureOn.ContenidoEN contenido
                             , Nullable<DateTime> fecha, float nota, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.UsuarioEN> usuario
                             )
{
        this.init (Id, contenido, fecha, nota, usuario);
}


public ValoracionContenidoEN(ValoracionContenidoEN valoracionContenido)
{
        this.init (Id, valoracionContenido.Contenido, valoracionContenido.Fecha, valoracionContenido.Nota, valoracionContenido.Usuario);
}

private void init (string id
                   , YoureOnGenNHibernate.EN.YoureOn.ContenidoEN contenido, Nullable<DateTime> fecha, float nota, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.UsuarioEN> usuario)
{
        this.Id = id;


        this.Contenido = contenido;

        this.Fecha = fecha;

        this.Nota = nota;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ValoracionContenidoEN t = obj as ValoracionContenidoEN;
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
