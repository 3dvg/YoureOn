
using System;
// Definición clase FaltaEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class FaltaEN
{
/**
 *	Atributo id_falta
 */
private int id_falta;



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






public virtual int Id_falta {
        get { return id_falta; } set { id_falta = value;  }
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



public FaltaEN(int id_falta, YoureOnGenNHibernate.Enumerated.YoureOn.TipoFaltaEnum tipoFalta, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, Nullable<DateTime> fecha, YoureOnGenNHibernate.EN.YoureOn.ModeradorEN moderador
               )
{
        this.init (Id_falta, tipoFalta, usuario, fecha, moderador);
}


public FaltaEN(FaltaEN falta)
{
        this.init (Id_falta, falta.TipoFalta, falta.Usuario, falta.Fecha, falta.Moderador);
}

private void init (int id_falta
                   , YoureOnGenNHibernate.Enumerated.YoureOn.TipoFaltaEnum tipoFalta, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, Nullable<DateTime> fecha, YoureOnGenNHibernate.EN.YoureOn.ModeradorEN moderador)
{
        this.Id_falta = id_falta;


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
        if (Id_falta.Equals (t.Id_falta))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id_falta.GetHashCode ();
        return hash;
}
}
}
