
using System;
// Definición clase ReporteEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class ReporteEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo usuario
 */
private YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual YoureOnGenNHibernate.EN.YoureOn.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public ReporteEN()
{
}



public ReporteEN(int id, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario
                 )
{
        this.init (Id, usuario);
}


public ReporteEN(ReporteEN reporte)
{
        this.init (Id, reporte.Usuario);
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
        ReporteEN t = obj as ReporteEN;
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
