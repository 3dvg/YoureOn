
using System;
// Definición clase AdministradorEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class AdministradorEN                                                                        : YoureOnGenNHibernate.EN.YoureOn.ModeradorEN


{
/**
 *	Atributo permisoAdministrador
 */
private string permisoAdministrador;






public virtual string PermisoAdministrador {
        get { return permisoAdministrador; } set { permisoAdministrador = value;  }
}





public AdministradorEN() : base ()
{
}



public AdministradorEN(string email, string permisoAdministrador
                       , string permisoModerador, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.FaltaEN> pone_falta, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.NotificacionesEN> notificacion_enviada
                       , string nombre, string apellidos, Nullable<DateTime> fechaNac, string nIF, string foto, String contrasenya, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> contenido, YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN biblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.FaltaEN> falta, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.NotificacionesEN> notificaciones, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporteEN> reporte
                       )
        {
            this.init (Email, permisoAdministrador, permisoModerador, pone_falta, notificacion_enviada, nombre, apellidos, fechaNac, nIF, foto, contrasenya, contenido, biblioteca, comentario, falta, notificaciones, reporte);
        }


        public AdministradorEN(AdministradorEN administrador)
        {
            this.init (Email, administrador.PermisoAdministrador, administrador.PermisoModerador, administrador.Pone_falta, administrador.Notificacion_enviada, administrador.Nombre, administrador.Apellidos, administrador.FechaNac, administrador.NIF, administrador.Foto, administrador.Contrasenya, administrador.Contenido, administrador.Biblioteca, administrador.Comentario, administrador.Falta, administrador.Notificaciones, administrador.Reporte);
        }

        private void init (string email
                           , string permisoAdministrador, string permisoModerador, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.FaltaEN> pone_falta, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.NotificacionesEN> notificacion_enviada, string nombre, string apellidos, Nullable<DateTime> fechaNac, string nIF, string foto, String contrasenya, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> contenido, YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN biblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.FaltaEN> falta, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.NotificacionesEN> notificaciones, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporteEN> reporte)
        {
            this.Email = email;


        this.PermisoAdministrador = permisoAdministrador;

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
        AdministradorEN t = obj as AdministradorEN;
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
