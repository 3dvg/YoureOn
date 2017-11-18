
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.CAD.YoureOn;
using YoureOnGenNHibernate.CEN.YoureOn;



/*PROTECTED REGION ID(usingYoureOnGenNHibernate.CP.YoureOn_ReporteComentario_enviarNotificacionReporte) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace YoureOnGenNHibernate.CP.YoureOn
{
public partial class ReporteComentarioCP : BasicCP
{
public void EnviarNotificacionReporte (int p_oid, YoureOnGenNHibernate.EN.YoureOn.ComentarioEN comentario, YoureOnGenNHibernate.EN.YoureOn.ModeradorEN moderador)
{
        /*PROTECTED REGION ID(YoureOnGenNHibernate.CP.YoureOn_ReporteComentario_enviarNotificacionReporte) ENABLED START*/

        IReporteComentarioCAD reporteComentarioCAD = null;
        ReporteComentarioCEN reporteComentarioCEN = null;
        String mensaje = "";



            try
            {
                SessionInitializeTransaction();
                reporteComentarioCAD = new ReporteComentarioCAD(session);
                reporteComentarioCEN = new ReporteComentarioCEN(reporteComentarioCAD);
                UsuarioEN usuarioEN = comentario.Usuario;
                if (reporteComentarioCEN != null)
                {
                    mensaje = "El usuario " + usuarioEN.Nombre + " con email " + usuarioEN.Email + " ha recibido quejas por su comentario: " + comentario.Id_comentario;
                    NotificacionesEN notificacion = new NotificacionesEN();
                    notificacion = new NotificacionesEN(notificacion.Id_notificacion, usuarioEN, mensaje, moderador);
                }
                SessionCommit();
            }
            catch (Exception ex)
            {
                SessionRollBack();
                throw ex;
            }
            finally
            {
                SessionClose();
            }
                               
                               
          /*PROTECTED REGION END*/
        }
}
}
