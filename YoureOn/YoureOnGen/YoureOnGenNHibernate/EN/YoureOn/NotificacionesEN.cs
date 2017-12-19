
using System;
// Definición clase NotificacionesEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class NotificacionesEN
{
/**
 *	Atributo id_notificacion
 */
private int id_notificacion;



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






public virtual int Id_notificacion {
        get { return id_notificacion; } set { id_notificacion = value;  }
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



public NotificacionesEN(int id_notificacion, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, string mensaje, YoureOnGenNHibernate.EN.YoureOn.ModeradorEN moderador
                        )
{
        this.init (Id_notificacion, usuario, mensaje, moderador);
}


public NotificacionesEN(NotificacionesEN notificaciones)
{
        this.init (Id_notificacion, notificaciones.Usuario, notificaciones.Mensaje, notificaciones.Moderador);
}

private void init (int id_notificacion
                   , YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, string mensaje, YoureOnGenNHibernate.EN.YoureOn.ModeradorEN moderador)
{
        this.Id_notificacion = id_notificacion;


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
        if (Id_notificacion.Equals (t.Id_notificacion))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id_notificacion.GetHashCode ();
        return hash;
}
}
}
