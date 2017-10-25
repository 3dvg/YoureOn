
using System;
// Definición clase YoureOnEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class YoureOnEN
{
/**
 *	Atributo id
 */
private int id;






public virtual int Id {
        get { return id; } set { id = value;  }
}





public YoureOnEN()
{
}



public YoureOnEN(int id
                 )
{
        this.init (Id);
}


public YoureOnEN(YoureOnEN youreOn)
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
        YoureOnEN t = obj as YoureOnEN;
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
