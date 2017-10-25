
using System;
// Definición clase FooterEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class FooterEN
{
/**
 *	Atributo id
 */
private int id;






public virtual int Id {
        get { return id; } set { id = value;  }
}





public FooterEN()
{
}



public FooterEN(int id
                )
{
        this.init (Id);
}


public FooterEN(FooterEN footer)
{
        this.init (Id);
}

private void init (int id
                   )
{
        this.Id = id;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        FooterEN t = obj as FooterEN;
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
