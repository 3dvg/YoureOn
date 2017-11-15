
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
 * Clase Falta:
 *
 */

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial class FaltaCAD : BasicCAD, IFaltaCAD
{
public FaltaCAD() : base ()
{
}

public FaltaCAD(ISession sessionAux) : base (sessionAux)
{
}



public FaltaEN ReadOIDDefault (int id_falta
                               )
{
        FaltaEN faltaEN = null;

        try
        {
                SessionInitializeTransaction ();
                faltaEN = (FaltaEN)session.Get (typeof(FaltaEN), id_falta);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in FaltaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return faltaEN;
}

public System.Collections.Generic.IList<FaltaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<FaltaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(FaltaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<FaltaEN>();
                        else
                                result = session.CreateCriteria (typeof(FaltaEN)).List<FaltaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in FaltaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (FaltaEN falta)
{
        try
        {
                SessionInitializeTransaction ();
                FaltaEN faltaEN = (FaltaEN)session.Load (typeof(FaltaEN), falta.Id_falta);

                faltaEN.TipoFalta = falta.TipoFalta;



                faltaEN.Fecha = falta.Fecha;


                session.Update (faltaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in FaltaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (FaltaEN falta)
{
        try
        {
                SessionInitializeTransaction ();
                if (falta.Usuario != null) {
                        // Argumento OID y no colección.
                        falta.Usuario = (YoureOnGenNHibernate.EN.YoureOn.UsuarioEN)session.Load (typeof(YoureOnGenNHibernate.EN.YoureOn.UsuarioEN), falta.Usuario.Email);

                        falta.Usuario.Falta
                        .Add (falta);
                }
                if (falta.Moderador != null) {
                        // Argumento OID y no colección.
                        falta.Moderador = (YoureOnGenNHibernate.EN.YoureOn.ModeradorEN)session.Load (typeof(YoureOnGenNHibernate.EN.YoureOn.ModeradorEN), falta.Moderador.Email);

                        falta.Moderador.Pone_falta
                        .Add (falta);
                }

                session.Save (falta);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in FaltaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return falta.Id_falta;
}

public void Modify (FaltaEN falta)
{
        try
        {
                SessionInitializeTransaction ();
                FaltaEN faltaEN = (FaltaEN)session.Load (typeof(FaltaEN), falta.Id_falta);

                faltaEN.TipoFalta = falta.TipoFalta;


                faltaEN.Fecha = falta.Fecha;

                session.Update (faltaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in FaltaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id_falta
                     )
{
        try
        {
                SessionInitializeTransaction ();
                FaltaEN faltaEN = (FaltaEN)session.Load (typeof(FaltaEN), id_falta);
                session.Delete (faltaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in FaltaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
