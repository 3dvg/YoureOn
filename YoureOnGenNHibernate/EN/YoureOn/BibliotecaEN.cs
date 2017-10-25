
using System;
// Definición clase BibliotecaEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class BibliotecaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo usuario
 */
private YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario;



/**
 *	Atributo contenido
 */
private System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> contenido;






public virtual int Id {
        get { return id; } set { id = value;  }
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



public BibliotecaEN(int id, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> contenido
                    )
{
        this.init (Id, usuario, contenido);
}


public BibliotecaEN(BibliotecaEN biblioteca)
{
        this.init (Id, biblioteca.Usuario, biblioteca.Contenido);
}

private void init (int id
                   , YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> contenido)
{
        this.Id = id;


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
