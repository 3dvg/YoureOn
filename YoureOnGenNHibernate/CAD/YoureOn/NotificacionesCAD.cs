
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
 * Clase Notificaciones:
 *
 */

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial class NotificacionesCAD : BasicCAD, INotificacionesCAD
{
public NotificacionesCAD() : base ()
{
}

public NotificacionesCAD(ISession sessionAux) : base (sessionAux)
{
}



public NotificacionesEN ReadOIDDefault (string id
                                        )
{
        NotificacionesEN notificacionesEN = null;

        try
        {
                SessionInitializeTransaction ();
                notificacionesEN = (NotificacionesEN)session.Get (typeof(NotificacionesEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in NotificacionesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return notificacionesEN;
}

public System.Collections.Generic.IList<NotificacionesEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<NotificacionesEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(NotificacionesEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<NotificacionesEN>();
                        else
                                result = session.CreateCriteria (typeof(NotificacionesEN)).List<NotificacionesEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in NotificacionesCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (NotificacionesEN notificaciones)
{
        try
        {
                SessionInitializeTransaction ();
                NotificacionesEN notificacionesEN = (NotificacionesEN)session.Load (typeof(NotificacionesEN), notificaciones.Id);


                notificacionesEN.Mensaje = notificaciones.Mensaje;


                session.Update (notificacionesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in NotificacionesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string New_ (NotificacionesEN notificaciones)
{
        try
        {
                SessionInitializeTransaction ();
                if (notificaciones.Usuario != null) {
                        // Argumento OID y no colección.
                        notificaciones.Usuario = (YoureOnGenNHibernate.EN.YoureOn.UsuarioEN)session.Load (typeof(YoureOnGenNHibernate.EN.YoureOn.UsuarioEN), notificaciones.Usuario.Email);

                        notificaciones.Usuario.Notificaciones
                        .Add (notificaciones);
                }
                if (notificaciones.Moderador != null) {
                        // Argumento OID y no colección.
                        notificaciones.Moderador = (YoureOnGenNHibernate.EN.YoureOn.ModeradorEN)session.Load (typeof(YoureOnGenNHibernate.EN.YoureOn.ModeradorEN), notificaciones.Moderador.Email);

                        notificaciones.Moderador.Notificacion_enviada
                        .Add (notificaciones);
                }

                session.Save (notificaciones);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in NotificacionesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return notificaciones.Id;
}

public void Modify (NotificacionesEN notificaciones)
{
        try
        {
                SessionInitializeTransaction ();
                NotificacionesEN notificacionesEN = (NotificacionesEN)session.Load (typeof(NotificacionesEN), notificaciones.Id);

                notificacionesEN.Mensaje = notificaciones.Mensaje;

                session.Update (notificacionesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in NotificacionesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                NotificacionesEN notificacionesEN = (NotificacionesEN)session.Load (typeof(NotificacionesEN), id);
                session.Delete (notificacionesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in NotificacionesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
