
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






public virtual string Id {
        get { return id; } set { id = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual float Nota {
        get { return nota; } set { nota = value;  }
}





public ValoracionEN()
{
}



public ValoracionEN(string id, Nullable<DateTime> fecha, float nota
                    )
{
        this.init (Id, fecha, nota);
}


public ValoracionEN(ValoracionEN valoracion)
{
        this.init (Id, valoracion.Fecha, valoracion.Nota);
}

private void init (string id
                   , Nullable<DateTime> fecha, float nota)
{
        this.Id = id;


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
