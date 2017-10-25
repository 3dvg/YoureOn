
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
 * Clase Audio:
 *
 */

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial class AudioCAD : BasicCAD, IAudioCAD
{
public AudioCAD() : base ()
{
}

public AudioCAD(ISession sessionAux) : base (sessionAux)
{
}



public AudioEN ReadOIDDefault (string titulo
                               )
{
        AudioEN audioEN = null;

        try
        {
                SessionInitializeTransaction ();
                audioEN = (AudioEN)session.Get (typeof(AudioEN), titulo);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in AudioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return audioEN;
}

public System.Collections.Generic.IList<AudioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<AudioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(AudioEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<AudioEN>();
                        else
                                result = session.CreateCriteria (typeof(AudioEN)).List<AudioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in AudioCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (AudioEN audio)
{
        try
        {
                SessionInitializeTransaction ();
                AudioEN audioEN = (AudioEN)session.Load (typeof(AudioEN), audio.Titulo);

                audioEN.Duracion = audio.Duracion;


                audioEN.FormatoAudio = audio.FormatoAudio;

                session.Update (audioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in AudioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string New_ (AudioEN audio)
{
        try
        {
                SessionInitializeTransaction ();
                if (audio.Usuario != null) {
                        // Argumento OID y no colección.
                        audio.Usuario = (YoureOnGenNHibernate.EN.YoureOn.UsuarioEN)session.Load (typeof(YoureOnGenNHibernate.EN.YoureOn.UsuarioEN), audio.Usuario.Email);

                        audio.Usuario.Contenido
                        .Add (audio);
                }

                session.Save (audio);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in AudioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return audio.Titulo;
}

public void Modify (AudioEN audio)
{
        try
        {
                SessionInitializeTransaction ();
                AudioEN audioEN = (AudioEN)session.Load (typeof(AudioEN), audio.Titulo);

                audioEN.TipoArchivo = audio.TipoArchivo;


                audioEN.Descripcion = audio.Descripcion;


                audioEN.Licencia = audio.Licencia;


                audioEN.Autor = audio.Autor;


                audioEN.EnBiblioteca = audio.EnBiblioteca;


                audioEN.Duracion = audio.Duracion;


                audioEN.FormatoAudio = audio.FormatoAudio;

                session.Update (audioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in AudioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string titulo
                     )
{
        try
        {
                SessionInitializeTransaction ();
                AudioEN audioEN = (AudioEN)session.Load (typeof(AudioEN), titulo);
                session.Delete (audioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in AudioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
