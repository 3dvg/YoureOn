
using System;
// Definición clase FaltaEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class FaltaEN
{
/**
 *	Atributo id
 */
private string id;



/**
 *	Atributo tipoFalta
 */
private YoureOnGenNHibernate.Enumerated.YoureOn.TipoFaltaEnum tipoFalta;



/**
 *	Atributo usuario
 */
private YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo moderador
 */
private YoureOnGenNHibernate.EN.YoureOn.ModeradorEN moderador;






public virtual string Id {
        get { return id; } set { id = value;  }
}



public virtual YoureOnGenNHibernate.Enumerated.YoureOn.TipoFaltaEnum TipoFalta {
        get { return tipoFalta; } set { tipoFalta = value;  }
}



public virtual YoureOnGenNHibernate.EN.YoureOn.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual YoureOnGenNHibernate.EN.YoureOn.ModeradorEN Moderador {
        get { return moderador; } set { moderador = value;  }
}





public FaltaEN()
{
}



public FaltaEN(string id, YoureOnGenNHibernate.Enumerated.YoureOn.TipoFaltaEnum tipoFalta, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, Nullable<DateTime> fecha, YoureOnGenNHibernate.EN.YoureOn.ModeradorEN moderador
               )
{
        this.init (Id, tipoFalta, usuario, fecha, moderador);
}


public FaltaEN(FaltaEN falta)
{
        this.init (Id, falta.TipoFalta, falta.Usuario, falta.Fecha, falta.Moderador);
}

private void init (string id
                   , YoureOnGenNHibernate.Enumerated.YoureOn.TipoFaltaEnum tipoFalta, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, Nullable<DateTime> fecha, YoureOnGenNHibernate.EN.YoureOn.ModeradorEN moderador)
{
        this.Id = id;


        this.TipoFalta = tipoFalta;

        this.Usuario = usuario;

        this.Fecha = fecha;

        this.Moderador = moderador;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        FaltaEN t = obj as FaltaEN;
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
