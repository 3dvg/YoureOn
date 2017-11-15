
using System;
// Definición clase ReporteEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class ReporteEN
{
/**
 *	Atributo id_reporte
 */
private int id_reporte;



/**
 *	Atributo usuario
 */
private YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario;






public virtual int Id_reporte {
        get { return id_reporte; } set { id_reporte = value;  }
}



public virtual YoureOnGenNHibernate.EN.YoureOn.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public ReporteEN()
{
}



public ReporteEN(int id_reporte, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario
                 )
{
        this.init (Id_reporte, usuario);
}


public ReporteEN(ReporteEN reporte)
{
        this.init (Id_reporte, reporte.Usuario);
}

private void init (int id_reporte
                   , YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario)
{
        this.Id_reporte = id_reporte;


        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ReporteEN t = obj as ReporteEN;
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
