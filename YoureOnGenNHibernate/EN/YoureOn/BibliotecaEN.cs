
using System;
// Definición clase BibliotecaEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class BibliotecaEN
{
/**
 *	Atributo id_biblio
 */
private int id_biblio;



/**
 *	Atributo usuario
 */
private YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario;



/**
 *	Atributo contenido
 */
private System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> contenido;






public virtual int Id_biblio {
        get { return id_biblio; } set { id_biblio = value;  }
}



public virtual YoureOnGenNHibernate.EN.YoureOn.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> Contenido {
        get { return contenido; } set { contenido = value;  }
}





public BibliotecaEN()
{
        contenido = new System.Collections.Generic.List<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN>();
}



public BibliotecaEN(int id_biblio, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> contenido
                    )
{
        this.init (Id_biblio, usuario, contenido);
}


public BibliotecaEN(BibliotecaEN biblioteca)
{
        this.init (Id_biblio, biblioteca.Usuario, biblioteca.Contenido);
}

private void init (int id_biblio
                   , YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> contenido)
{
        this.Id_biblio = id_biblio;


        this.Usuario = usuario;

        this.Contenido = contenido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        BibliotecaEN t = obj as BibliotecaEN;
        if (t == null)
                return false;
        if (Id_biblio.Equals (t.Id_biblio))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id_biblio.GetHashCode ();
        return hash;
}
}
}
