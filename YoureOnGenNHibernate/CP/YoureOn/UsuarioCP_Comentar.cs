
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.CAD.YoureOn;
using YoureOnGenNHibernate.CEN.YoureOn;



/*PROTECTED REGION ID(usingYoureOnGenNHibernate.CP.YoureOn_Usuario_comentar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace YoureOnGenNHibernate.CP.YoureOn
{
public partial class UsuarioCP : BasicCP
{
public int Comentar (string usuario_oid, int contenido_oid, string texto)
{
        /*PROTECTED REGION ID(YoureOnGenNHibernate.CP.YoureOn_Usuario_comentar) ENABLED START*/

        IUsuarioCAD usuarioCAD = null;
        IContenidoCAD contenidoCAD = null;
        UsuarioCEN usuarioCEN = null;
        ContenidoCEN contenidoCEN = null;
        UsuarioEN usuario = null;
        ContenidoEN contenido = null;

        int result = -1;

        try
        {
                SessionInitializeTransaction ();
                usuarioCAD = new UsuarioCAD (session);
                contenidoCAD = new ContenidoCAD (session);

                usuarioCEN = new UsuarioCEN (usuarioCAD);
                contenidoCEN = new ContenidoCEN (contenidoCAD);

                usuario = usuarioCAD.ReadOIDDefault (usuario_oid);
                contenido = contenidoCAD.ReadOIDDefault (contenido_oid);

                // Le paso la valoración a null de momento y el id 0
                ComentarioEN comentario = new ComentarioEN (0, texto, DateTime.Now, usuario, null, contenido, null);

                usuario.Comentario.Add (comentario);
                contenido.Comentario.Add (comentario);

                // Esto haría falta hacerlo para guardar en la BD ???????????
                /*usuarioCEN.EditarPerfil(usuario);
                 * contenidoCEN.Modificar(contenido);*/

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
