

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using YoureOnGenNHibernate.Exceptions;

using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.CAD.YoureOn;


namespace YoureOnGenNHibernate.CEN.YoureOn
{
/*
 *      Definition of the class NotificacionesCEN
 *
 */
public partial class NotificacionesCEN
{
private INotificacionesCAD _INotificacionesCAD;

public NotificacionesCEN()
{
        this._INotificacionesCAD = new NotificacionesCAD ();
}

public NotificacionesCEN(INotificacionesCAD _INotificacionesCAD)
{
        this._INotificacionesCAD = _INotificacionesCAD;
}

public INotificacionesCAD get_INotificacionesCAD ()
{
        return this._INotificacionesCAD;
}

public string New_ (string p_id, string p_usuario, string p_mensaje, string p_moderador)
{
        NotificacionesEN notificacionesEN = null;
        string oid;

        //Initialized NotificacionesEN
        notificacionesEN = new NotificacionesEN ();
        notificacionesEN.Id = p_id;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                notificacionesEN.Usuario = new YoureOnGenNHibernate.EN.YoureOn.UsuarioEN ();
                notificacionesEN.Usuario.Email = p_usuario;
        }

        notificacionesEN.Mensaje = p_mensaje;


        if (p_moderador != null) {
                // El argumento p_moderador -> Property moderador es oid = false
                // Lista de oids id
                notificacionesEN.Moderador = new YoureOnGenNHibernate.EN.YoureOn.ModeradorEN ();
                notificacionesEN.Moderador.Email = p_moderador;
        }

        //Call to NotificacionesCAD

        oid = _INotificacionesCAD.New_ (notificacionesEN);
        return oid;
}

public void Modify (string p_Notificaciones_OID, string p_mensaje)
{
        NotificacionesEN notificacionesEN = null;

        //Initialized NotificacionesEN
        notificacionesEN = new NotificacionesEN ();
        notificacionesEN.Id = p_Notificaciones_OID;
        notificacionesEN.Mensaje = p_mensaje;
        //Call to NotificacionesCAD

        _INotificacionesCAD.Modify (notificacionesEN);
}

public void Destroy (string id
                     )
{
        _INotificacionesCAD.Destroy (id);
}
}
}
