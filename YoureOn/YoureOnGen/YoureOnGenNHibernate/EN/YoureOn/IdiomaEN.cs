
using System;
// Definición clase IdiomaEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class IdiomaEN
{
/**
 *	Atributo idioma
 */
private string idioma;



/**
 *	Atributo descripcion
 */
private string descripcion;






public virtual string Idioma {
        get { return idioma; } set { idioma = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}





public IdiomaEN()
{
}



public IdiomaEN(string idioma, string descripcion
                )
{
        this.init (Idioma, descripcion);
}


public IdiomaEN(IdiomaEN idioma)
{
        this.init (Idioma, idioma.Descripcion);
}

private void init (string idioma
                   , string descripcion)
{
        this.Idioma = idioma;


        this.Descripcion = descripcion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        IdiomaEN t = obj as IdiomaEN;
        if (t == null)
                return false;
        if (Idioma.Equals (t.Idioma))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Idioma.GetHashCode ();
        return hash;
}
}
}
