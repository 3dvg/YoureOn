
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.CAD.YoureOn;
using YoureOnGenNHibernate.CEN.YoureOn;



/*PROTECTED REGION ID(usingYoureOnGenNHibernate.CP.YoureOn_ReporteContenido_enviarNotificacionReporte) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace YoureOnGenNHibernate.CP.YoureOn
{
    public partial class ReporteContenidoCP : BasicCP
    {
        public void EnviarNotificacionReporte(int p_oid, YoureOnGenNHibernate.EN.YoureOn.ContenidoEN contenido, YoureOnGenNHibernate.EN.YoureOn.ModeradorEN moderador)
        {
            {
                /*PROTECTED REGION ID(YoureOnGenNHibernate.CP.YoureOn_ReporteComentario_enviarNotificacionReporte) ENABLED START*/

                IReporteContenidoCAD reporteContenidoCAD = null;
                ReporteContenidoCEN reporteContenidoCEN = null;
                String mensaje = "";



                try
                {
                    SessionInitializeTransaction();
                    reporteContenidoCAD = new ReporteContenidoCAD(session);
                    reporteContenidoCEN = new ReporteContenidoCEN(reporteContenidoCAD);
                    UsuarioEN usuarioEN = contenido.Usuario;
                    if (reporteContenidoCEN != null)
                    {
                        mensaje = "El usuario " + usuarioEN.Nombre + " con email " + usuarioEN.Email + " ha recibido quejas por su contenido: " + contenido.Id_contenido;
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
}