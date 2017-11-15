
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
        ComentarioCAD comentarioCAD = null;
        ComentarioCEN comentarioCEN = null;
        ContenidoCAD contenidoCAD = null;
        ContenidoCEN contenidoCEN = null;
        float result, sumaContenido, sumaComentario;

        try
        {
                SessionInitializeTransaction ();
                usuarioCAD = new UsuarioCAD (session);
                comentarioCAD = new ComentarioCAD(session);
                contenidoCAD = new ContenidoCAD(session);

                usuario = usuarioCAD.ReadOIDDefault (usuario_oid);
                comentarioCEN = new ComentarioCEN(comentarioCAD);
                contenidoCEN = new ContenidoCEN(contenidoCAD);

                result = sumaContenido = sumaComentario = 0;

                if (usuario != null) {
                        System.Collections.Generic.IList<ContenidoEN> lista_contenidos = usuario.Contenido;
                        System.Collections.Generic.IList<ComentarioEN> lista_comentarios = usuario.Comentario;

                        foreach (ContenidoEN contenido in lista_contenidos) {
                            sumaContenido += contenidoCEN.GetPuntuacionContenido(contenido.Id_contenido);
                        }

                        foreach (ComentarioEN comentario in lista_comentarios)
                        {
                            sumaComentario += comentarioCEN.GetPuntuacionComentario(comentario.Id_comentario);
                        }
                        
                        result = (sumaContenido + sumaComentario) / 2;
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
