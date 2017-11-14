
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
public void PoneFalta (string p_oid, YoureOnGenNHibernate.Enumerated.YoureOn.TipoFaltaEnum tipoFalta, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, YoureOnGenNHibernate.EN.YoureOn.ModeradorEN moderador, Nullable<DateTime> fechaFalta)
{
            /*PROTECTED REGION ID(YoureOnGenNHibernate.CEN.YoureOn_Moderador_poneFalta) ENABLED START*/

            // Write here your custom code...
            ModeradorEN moderadorEN = _IModeradorCAD.ReadOIDDefault(p_oid);
            NotificacionesEN notificacionEN = new NotificacionesEN();
        if (p_oid != null) {
                FaltaEN faltaUsuario = new FaltaEN (p_oid, tipoFalta, usuario, fechaFalta, moderadorEN);
                usuario.Falta.Add(faltaUsuario);
                if (usuario.Falta.Count == 3)
                    this.EnviarNotificacion(administradorEN.Email);
        }

        //throw new NotImplementedException ("Method PoneFalta() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
