
using System;
// Definición clase ValoracionEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class ValoracionEN
{
/**
 *	Atributo id_valoracion
 */
private int id_valoracion;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo nota
 */
private int nota;






public virtual int Id_valoracion {
        get { return id_valoracion; } set { id_valoracion = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual int Nota {
        get { return nota; } set { nota = value;  }
}





public ValoracionEN()
{
}



public ValoracionEN(int id_valoracion, Nullable<DateTime> fecha, int nota
                    )
{
        this.init (Id_valoracion, fecha, nota);
}


public ValoracionEN(ValoracionEN valoracion)
{
        this.init (Id_valoracion, valoracion.Fecha, valoracion.Nota);
}

private void init (int id_valoracion
                   , Nullable<DateTime> fecha, int nota)
{
        this.Id_valoracion = id_valoracion;


        this.Fecha = fecha;

        this.Nota = nota;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ValoracionEN t = obj as ValoracionEN;
        if (t == null)
                return false;
        if (Id_valoracion.Equals (t.Id_valoracion))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id_valoracion.GetHashCode ();
        return hash;
}
}
}
