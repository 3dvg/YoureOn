
using System;
// Definición clase UsuarioEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class UsuarioEN
{
/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo apellidos
 */
private string apellidos;



/**
 *	Atributo fechaNac
 */
private Nullable<DateTime> fechaNac;



/**
 *	Atributo nIF
 */
private string nIF;



/**
 *	Atributo foto
 */
private string foto;



/**
 *	Atributo contrasenya
 */
private String contrasenya;



/**
 *	Atributo contenido
 */
private System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> contenido;



/**
 *	Atributo biblioteca
 */
private YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN biblioteca;



/**
 *	Atributo comentario
 */
private System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario;



/**
 *	Atributo falta
 */
private System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.FaltaEN> falta;



/**
 *	Atributo notificaciones
 */
private System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.NotificacionesEN> notificaciones;



/**
 *	Atributo valoracion
 */
private System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionEN> valoracion;



/**
 *	Atributo reporte
 */
private System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporteEN> reporte;






public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}



public virtual Nullable<DateTime> FechaNac {
        get { return fechaNac; } set { fechaNac = value;  }
}



public virtual string NIF {
        get { return nIF; } set { nIF = value;  }
}



public virtual string Foto {
        get { return foto; } set { foto = value;  }
}



public virtual String Contrasenya {
        get { return contrasenya; } set { contrasenya = value;  }
}



public virtual System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> Contenido {
        get { return contenido; } set { contenido = value;  }
}



public virtual YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN Biblioteca {
        get { return biblioteca; } set { biblioteca = value;  }
}



public virtual System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.FaltaEN> Falta {
        get { return falta; } set { falta = value;  }
}



public virtual System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.NotificacionesEN> Notificaciones {
        get { return notificaciones; } set { notificaciones = value;  }
}



public virtual System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionEN> Valoracion {
        get { return valoracion; } set { valoracion = value;  }
}



public virtual System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporteEN> Reporte {
        get { return reporte; } set { reporte = value;  }
}





public UsuarioEN()
{
        contenido = new System.Collections.Generic.List<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN>();
        comentario = new System.Collections.Generic.List<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN>();
        falta = new System.Collections.Generic.List<YoureOnGenNHibernate.EN.YoureOn.FaltaEN>();
        notificaciones = new System.Collections.Generic.List<YoureOnGenNHibernate.EN.YoureOn.NotificacionesEN>();
        valoracion = new System.Collections.Generic.List<YoureOnGenNHibernate.EN.YoureOn.ValoracionEN>();
        reporte = new System.Collections.Generic.List<YoureOnGenNHibernate.EN.YoureOn.ReporteEN>();
}



public UsuarioEN(string email, string nombre, string apellidos, Nullable<DateTime> fechaNac, string nIF, string foto, String contrasenya, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> contenido, YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN biblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.FaltaEN> falta, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.NotificacionesEN> notificaciones, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionEN> valoracion, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporteEN> reporte
                 )
{
        this.init (Email, nombre, apellidos, fechaNac, nIF, foto, contrasenya, contenido, biblioteca, comentario, falta, notificaciones, valoracion, reporte);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (Email, usuario.Nombre, usuario.Apellidos, usuario.FechaNac, usuario.NIF, usuario.Foto, usuario.Contrasenya, usuario.Contenido, usuario.Biblioteca, usuario.Comentario, usuario.Falta, usuario.Notificaciones, usuario.Valoracion, usuario.Reporte);
}

private void init (string email
                   , string nombre, string apellidos, Nullable<DateTime> fechaNac, string nIF, string foto, String contrasenya, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> contenido, YoureOnGenNHibernate.EN.YoureOn.BibliotecaEN biblioteca, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ComentarioEN> comentario, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.FaltaEN> falta, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.NotificacionesEN> notificaciones, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ValoracionEN> valoracion, System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ReporteEN> reporte)
{
        this.Email = email;


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

        this.Valoracion = valoracion;

        this.Reporte = reporte;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
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
