
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using YoureOnGenNHibernate.Exceptions;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.CAD.YoureOn;


/*PROTECTED REGION ID(usingYoureOnGenNHibernate.CEN.YoureOn_Moderador_enviarNotificacion) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace YoureOnGenNHibernate.CEN.YoureOn
{
public partial class ModeradorCEN
{
public void EnviarNotificacion (string moderador_oid, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, string mensaje)
{
        /*PROTECTED REGION ID(YoureOnGenNHibernate.CEN.YoureOn_Moderador_enviarNotificacion) ENABLED START*/

        ModeradorEN moderador = new ModeradorEN ();

        moderador = _IModeradorCAD.ReadOIDDefault (moderador.Email);
        NotificacionesEN notificacion = new NotificacionesEN ();

        if (usuario != null && !mensaje.Equals ("") && moderador != null) {
                notificacion = new NotificacionesEN (notificacion.Id_notificacion, usuario, mensaje, moderador);
        }

        /*PROTECTED REGION END*/
}
}
}
