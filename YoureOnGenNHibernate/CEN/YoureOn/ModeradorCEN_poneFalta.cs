
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


/*PROTECTED REGION ID(usingYoureOnGenNHibernate.CEN.YoureOn_Moderador_poneFalta) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace YoureOnGenNHibernate.CEN.YoureOn
{
public partial class ModeradorCEN
{
public void PoneFalta (string moderador_oid, YoureOnGenNHibernate.Enumerated.YoureOn.TipoFaltaEnum tipoFalta, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, Nullable<DateTime> fechaFalta, YoureOnGenNHibernate.EN.YoureOn.AdministradorEN administrador)
{
        /*PROTECTED REGION ID(YoureOnGenNHibernate.CEN.YoureOn_Moderador_poneFalta) ENABLED START*/

        // Write here your custom code...
        ModeradorEN moderadorEN = _IModeradorCAD.ReadOIDDefault (moderador_oid);
        NotificacionesEN notificacionEN = new NotificacionesEN ();
        FaltaEN faltaUsuario = new FaltaEN ();
        String mensaje = "";

        if (moderador_oid != null) {
                faltaUsuario = new FaltaEN (faltaUsuario.Id_falta, tipoFalta, usuario, fechaFalta, moderadorEN);
                usuario.Falta.Add (faltaUsuario);
                if (usuario.Falta.Count == 3) {
                        mensaje = "El usuario" + usuario.Email + "ha cometido 3 faltas leves";
                        this.EnviarNotificacion (moderadorEN.Email, administrador, mensaje);
                }
                else if (faltaUsuario.TipoFalta.Equals ("2") || faltaUsuario.TipoFalta.Equals ("grave")) {
                        mensaje = "El usuario" + usuario.Email + "ha cometido una falta grave";
                        this.EnviarNotificacion (moderadorEN.Email, administrador, mensaje);
                }
        }

        //throw new NotImplementedException ("Method PoneFalta() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
