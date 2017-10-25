
using System;
// Definición clase NotificacionesEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class NotificacionesEN
{
/**
 *	Atributo id
 */
private string id;



/**
 *	Atributo usuario
 */
private YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario;



/**
 *	Atributo mensaje
 */
private string mensaje;



/**
 *	Atributo moderador
 */
private YoureOnGenNHibernate.EN.YoureOn.ModeradorEN moderador;






public virtual string Id {
        get { return id; } set { id = value;  }
}



public virtual YoureOnGenNHibernate.EN.YoureOn.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual string Mensaje {
        get { return mensaje; } set { mensaje = value;  }
}



public virtual YoureOnGenNHibernate.EN.YoureOn.ModeradorEN Moderador {
        get { return moderador; } set { moderador = value;  }
}





public NotificacionesEN()
{
}



public NotificacionesEN(string id, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, string mensaje, YoureOnGenNHibernate.EN.YoureOn.ModeradorEN moderador
                        )
{
        this.init (Id, usuario, mensaje, moderador);
}


public NotificacionesEN(NotificacionesEN notificaciones)
{
        this.init (Id, notificaciones.Usuario, notificaciones.Mensaje, notificaciones.Moderador);
}

private void init (string id
                   , YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, string mensaje, YoureOnGenNHibernate.EN.YoureOn.ModeradorEN moderador)
{
        this.Id = id;


        this.Usuario = usuario;

        this.Mensaje = mensaje;

        this.Moderador = moderador;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        NotificacionesEN t = obj as NotificacionesEN;
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
