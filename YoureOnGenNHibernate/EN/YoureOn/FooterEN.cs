
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






public virtual int Id_footer {
        get { return id_footer; } set { id_footer = value;  }
}



public virtual string Enlace {
        get { return enlace; } set { enlace = value;  }
}





public FooterEN()
{
}



public FooterEN(int id_footer, string enlace
                )
{
        this.init (Id_footer, enlace);
}


public FooterEN(FooterEN footer)
{
        this.init (Id_footer, footer.Enlace);
}

private void init (int id_footer
                   , string enlace)
{
        this.Id_footer = id_footer;


        this.Enlace = enlace;
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
