
using System;
// Definición clase FooterEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class FooterEN
{
/**
 *	Atributo id_footer
 */
private int id_footer;



/**
 *	Atributo enlace
 */
private string enlace;



/**
 *	Atributo descripcion
 */
private string descripcion;






public virtual int Id_footer {
        get { return id_footer; } set { id_footer = value;  }
}



public virtual string Enlace {
        get { return enlace; } set { enlace = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}





public FooterEN()
{
}



public FooterEN(int id_footer, string enlace, string descripcion
                )
{
        this.init (Id_footer, enlace, descripcion);
}


public FooterEN(FooterEN footer)
{
        this.init (Id_footer, footer.Enlace, footer.Descripcion);
}

private void init (int id_footer
                   , string enlace, string descripcion)
{
        this.Id_footer = id_footer;


        this.Enlace = enlace;

        this.Descripcion = descripcion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        FooterEN t = obj as FooterEN;
        if (t == null)
                return false;
        if (Id_footer.Equals (t.Id_footer))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id_footer.GetHashCode ();
        return hash;
}
}
}
