
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
 * Clase Moderador:
 *
 */

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial class ModeradorCAD : BasicCAD, IModeradorCAD
{
public ModeradorCAD() : base ()
{
}

public ModeradorCAD(ISession sessionAux) : base (sessionAux)
{
}



public ModeradorEN ReadOIDDefault (string email
                                   )
{
        ModeradorEN moderadorEN = null;

        try
        {
                SessionInitializeTransaction ();
                moderadorEN = (ModeradorEN)session.Get (typeof(ModeradorEN), email);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ModeradorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return moderadorEN;
}

public System.Collections.Generic.IList<ModeradorEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ModeradorEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ModeradorEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ModeradorEN>();
                        else
                                result = session.CreateCriteria (typeof(ModeradorEN)).List<ModeradorEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ModeradorCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ModeradorEN moderador)
{
        try
        {
                SessionInitializeTransaction ();
                ModeradorEN moderadorEN = (ModeradorEN)session.Load (typeof(ModeradorEN), moderador.Email);

                moderadorEN.PermisoModerador = moderador.PermisoModerador;



                session.Update (moderadorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ModeradorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string New_ (ModeradorEN moderador)
{
        try
        {
                SessionInitializeTransaction ();
                if (moderador.Valoracion != null) {
                        // Argumento OID y no colección.
                        moderador.Valoracion = (YoureOnGenNHibernate.EN.YoureOn.ValoracionEN)session.Load (typeof(YoureOnGenNHibernate.EN.YoureOn.ValoracionEN), moderador.Valoracion.Id);

                        moderador.Valoracion.Usuario
                        .Add (moderador);
                }

                session.Save (moderador);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ModeradorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return moderador.Email;
}

public void Modify (ModeradorEN moderador)
{
        try
        {
                SessionInitializeTransaction ();
                ModeradorEN moderadorEN = (ModeradorEN)session.Load (typeof(ModeradorEN), moderador.Email);

                moderadorEN.Nombre = moderador.Nombre;


                moderadorEN.Apellidos = moderador.Apellidos;


                moderadorEN.FechaNac = moderador.FechaNac;


                moderadorEN.NIF = moderador.NIF;


                moderadorEN.Foto = moderador.Foto;


                moderadorEN.Contrasenya = moderador.Contrasenya;


                moderadorEN.PermisoModerador = moderador.PermisoModerador;

                session.Update (moderadorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ModeradorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string email
                     )
{
        try
        {
                SessionInitializeTransaction ();
                ModeradorEN moderadorEN = (ModeradorEN)session.Load (typeof(ModeradorEN), email);
                session.Delete (moderadorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ModeradorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
