
using System;
// Definición clase BusquedaEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class BusquedaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo contenido
 */
private System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> contenido;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> Contenido {
        get { return contenido; } set { contenido = value;  }
}





public BusquedaEN()
{
        contenido = new System.Collections.Generic.List<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN>();
}



public BusquedaEN(int id, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> contenido
                  )
{
        this.init (Id, contenido);
}


public BusquedaEN(BusquedaEN busqueda)
{
        this.init (Id, busqueda.Contenido);
}

private void init (int id
                   , System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> contenido)
{
        this.Id = id;


        this.Contenido = contenido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        BusquedaEN t = obj as BusquedaEN;
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
