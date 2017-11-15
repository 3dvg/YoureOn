
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.CAD.YoureOn;
using YoureOnGenNHibernate.CEN.YoureOn;


/*PROTECTED REGION ID(usingYoureOnGenNHibernate.CP.YoureOn_Usuario_getPuntuacion) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace YoureOnGenNHibernate.CP.YoureOn
{
public partial class UsuarioCP : BasicCP
{
public float GetPuntuacion (string usuario_oid)
{
        /*PROTECTED REGION ID(YoureOnGenNHibernate.CP.YoureOn_Usuario_getPuntuacion) ENABLED START*/

        IUsuarioCAD usuarioCAD = null;
        UsuarioEN usuario = null;
        float result, sumaContenido, sumaComentario, mediaContenidos, mediaComentarios;

        try
        {
                SessionInitializeTransaction ();
                usuarioCAD = new UsuarioCAD (session);
                usuario = usuarioCAD.ReadOIDDefault (usuario_oid);
                result = sumaContenido = sumaComentario = mediaContenidos = mediaComentarios = 0;

                if (usuario != null) {
                        System.Collections.Generic.IList<ContenidoEN> lista_contenidos = usuario.Contenido;
                        System.Collections.Generic.IList<ComentarioEN> lista_comentarios = usuario.Comentario;

                        foreach (ContenidoEN content in lista_contenidos) {
                                foreach (ValoracionContenidoEN val_contenido in content.Valoracion_contenido) {
                                        sumaContenido += val_contenido.Nota;
                                }
                        }

                        foreach (ComentarioEN comentario in lista_comentarios) {
                                foreach (ValoracionComentarioEN val_comentario in comentario.Valoracion_comentario) {
                                        sumaComentario += val_comentario.Nota;
                                }
                        }

                        mediaContenidos = sumaContenido / lista_contenidos.Count;
                        mediaComentarios = sumaComentario / lista_comentarios.Count;
                        result = (mediaContenidos + mediaComentarios) / 2;
                }
                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }
        return result;


        /*PROTECTED REGION END*/
}
}
}
