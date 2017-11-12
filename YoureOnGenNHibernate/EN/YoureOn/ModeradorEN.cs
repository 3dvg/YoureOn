
using System;
// Definición clase ModeradorEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class ModeradorEN                                                                    : YoureOnGenNHibernate.EN.YoureOn.UsuarioEN


{
/**
 *	Atributo permisoModerador
 */
private string permisoModerador;



/**
 *	Atributo pone_falta
 */
private System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.FaltaEN> pone_falta;



/**
 *	Atributo notificacion_enviada
 */
private System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.NotificacionesEN> notificacion_enviada;






public virtual string PermisoModerador {
        get { return permisoModerador; } set { permisoModerador = value;  }
}



public virtual System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.FaltaEN> Pone_falta {
        get { return pone_falta; } set { pone_falta = value;  }
}



public virtual System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.NotificacionesEN> Notificacion_enviada {
        get { return notificacion_enviada; } set { notificacion_enviada = value;  }
}





public ModeradorEN() : base ()
{
        pone_falta = new System.Collections.Generic.List<YoureOnGenNHibernate.EN.YoureOn.FaltaEN>();
        notificacion_enviada = new System.Collections.Generic.List<YoureOnGenNHibernate.EN.YoureOn.NotificacionesEN>();
}



public ModeradorEN(string email, string permisoModerador, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.FaltaEN> pone_falta, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.NotificacionesEN> notificacion_enviada
                   , string nombre, string apellidos, Nullable<DateTime> fechaNac, string nIF, string foto, String contrasenya, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> contenido, YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN biblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.FaltaEN> falta, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.NotificacionesEN> notificaciones, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporteEN> reporte
                   )
{
        this.init (Email, permisoModerador, pone_falta, notificacion_enviada, nombre, apellidos, fechaNac, nIF, foto, contrasenya, contenido, biblioteca, comentario, falta, notificaciones, reporte);
}


public ModeradorEN(ModeradorEN moderador)
{
        this.init (Email, moderador.PermisoModerador, moderador.Pone_falta, moderador.Notificacion_enviada, moderador.Nombre, moderador.Apellidos, moderador.FechaNac, moderador.NIF, moderador.Foto, moderador.Contrasenya, moderador.Contenido, moderador.Biblioteca, moderador.Comentario, moderador.Falta, moderador.Notificaciones, moderador.Reporte);
}

private void init (string email
                   , string permisoModerador, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.FaltaEN> pone_falta, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.NotificacionesEN> notificacion_enviada, string nombre, string apellidos, Nullable<DateTime> fechaNac, string nIF, string foto, String contrasenya, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> contenido, YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN biblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.FaltaEN> falta, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.NotificacionesEN> notificaciones, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporteEN> reporte)
{
        this.Email = email;


        this.PermisoModerador = permisoModerador;

        this.Pone_falta = pone_falta;

        this.Notificacion_enviada = notificacion_enviada;

        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.FechaNac = fechaNac;

        this.NIF = nIF;

        this.Foto = foto;

        this.Contrasenya = contrasenya;

        this.Contenido = contenido;

        this.Biblioteca = biblioteca;

        this.Comentario = comentario;

        this.Falta = falta;

        this.Notificaciones = notificaciones;

        this.Reporte = reporte;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ModeradorEN t = obj as ModeradorEN;
        if (t == null)
                return false;
        if (Email.Equals (t.Email))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Email.GetHashCode ();
        return hash;
}
}
}
