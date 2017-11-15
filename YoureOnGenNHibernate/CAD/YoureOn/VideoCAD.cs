
using System;
using System.Text;
using YoureOnGenNHibernate.CEN.YoureOn;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.Exceptions;


/*
 * Clase Video:
 *
 */

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial class VideoCAD : BasicCAD, IVideoCAD
{
public VideoCAD() : base ()
{
}

public VideoCAD(ISession sessionAux) : base (sessionAux)
{
}



public VideoEN ReadOIDDefault (int id_contenido
                               )
{
        VideoEN videoEN = null;

        try
        {
                SessionInitializeTransaction ();
                videoEN = (VideoEN)session.Get (typeof(VideoEN), id_contenido);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in VideoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return videoEN;
}

public System.Collections.Generic.IList<VideoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<VideoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(VideoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<VideoEN>();
                        else
                                result = session.CreateCriteria (typeof(VideoEN)).List<VideoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in VideoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (VideoEN video)
{
        try
        {
                SessionInitializeTransaction ();
                VideoEN videoEN = (VideoEN)session.Load (typeof(VideoEN), video.Id_contenido);

                videoEN.Duracion = video.Duracion;


                videoEN.Resolucion = video.Resolucion;


                videoEN.FormatoVideo = video.FormatoVideo;

                session.Update (videoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in VideoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (VideoEN video)
{
        try
        {
                SessionInitializeTransaction ();
                if (video.Usuario != null) {
                        // Argumento OID y no colección.
                        video.Usuario = (YoureOnGenNHibernate.EN.YoureOn.UsuarioEN)session.Load (typeof(YoureOnGenNHibernate.EN.YoureOn.UsuarioEN), video.Usuario.Email);

                        video.Usuario.Contenido
                        .Add (video);
                }

                session.Save (video);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in VideoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return video.Id_contenido;
}

public void Modify (VideoEN video)
{
        try
        {
                SessionInitializeTransaction ();
                VideoEN videoEN = (VideoEN)session.Load (typeof(VideoEN), video.Id_contenido);

                videoEN.Titulo = video.Titulo;


                videoEN.TipoArchivo = video.TipoArchivo;


                videoEN.Descripcion = video.Descripcion;


                videoEN.Licencia = video.Licencia;


                videoEN.Autor = video.Autor;


                videoEN.EnBiblioteca = video.EnBiblioteca;


                videoEN.Duracion = video.Duracion;


                videoEN.Resolucion = video.Resolucion;


                videoEN.FormatoVideo = video.FormatoVideo;

                session.Update (videoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in VideoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id_contenido
                     )
{
        try
        {
                SessionInitializeTransaction ();
                VideoEN videoEN = (VideoEN)session.Load (typeof(VideoEN), id_contenido);
                session.Delete (videoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in VideoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
