
using System;
// Definición clase ValoracionEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class ValoracionEN
{
/**
 *	Atributo id
 */
private string id;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo nota
 */
private float nota;



/**
 *	Atributo usuario
 */
private System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.UsuarioEN> usuario;






public virtual string Id {
        get { return id; } set { id = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual float Nota {
        get { return nota; } set { nota = value;  }
}



public virtual System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.UsuarioEN> Usuario {
        get { return usuario; } set { usuario = value;  }
}





public ValoracionEN()
{
        usuario = new System.Collections.Generic.List<YoureOnGenNHibernate.EN.YoureOn.UsuarioEN>();
}



public ValoracionEN(string id, Nullable<DateTime> fecha, float nota, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.UsuarioEN> usuario
                    )
{
        this.init (Id, fecha, nota, usuario);
}


public ValoracionEN(ValoracionEN valoracion)
{
        this.init (Id, valoracion.Fecha, valoracion.Nota, valoracion.Usuario);
}

private void init (string id
                   , Nullable<DateTime> fecha, float nota, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.UsuarioEN> usuario)
{
        this.Id = id;


        this.Fecha = fecha;

        this.Nota = nota;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ValoracionEN t = obj as ValoracionEN;
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
