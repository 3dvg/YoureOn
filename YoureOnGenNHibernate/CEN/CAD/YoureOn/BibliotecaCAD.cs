
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
 * Clase Biblioteca:
 *
 */

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial class BibliotecaCAD : BasicCAD, IBibliotecaCAD
{
public BibliotecaCAD() : base ()
{
}

public BibliotecaCAD(ISession sessionAux) : base (sessionAux)
{
}



public BibliotecaEN ReadOIDDefault (int id
                                    )
{
        BibliotecaEN bibliotecaEN = null;

        try
        {
                SessionInitializeTransaction ();
                bibliotecaEN = (BibliotecaEN)session.Get (typeof(BibliotecaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in BibliotecaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return bibliotecaEN;
}

public System.Collections.Generic.IList<BibliotecaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<BibliotecaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(BibliotecaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<BibliotecaEN>();
                        else
                                result = session.CreateCriteria (typeof(BibliotecaEN)).List<BibliotecaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in BibliotecaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (BibliotecaEN biblioteca)
{
        try
        {
                SessionInitializeTransaction ();
                BibliotecaEN bibliotecaEN = (BibliotecaEN)session.Load (typeof(BibliotecaEN), biblioteca.Id);


                session.Update (bibliotecaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in BibliotecaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (BibliotecaEN biblioteca)
{
        try
        {
                SessionInitializeTransaction ();
                if (biblioteca.Usuario != null) {
                        // Argumento OID y no colección.
                        biblioteca.Usuario = (YoureOnGenNHibernate.EN.YoureOn.UsuarioEN)session.Load (typeof(YoureOnGenNHibernate.EN.YoureOn.UsuarioEN), biblioteca.Usuario.Email);

                        biblioteca.Usuario.Biblioteca
                                = biblioteca;
                }

                session.Save (biblioteca);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in BibliotecaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return biblioteca.Id;
}

public void Modify (BibliotecaEN biblioteca)
{
        try
        {
                SessionInitializeTransaction ();
                BibliotecaEN bibliotecaEN = (BibliotecaEN)session.Load (typeof(BibliotecaEN), biblioteca.Id);
                session.Update (bibliotecaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in BibliotecaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                BibliotecaEN bibliotecaEN = (BibliotecaEN)session.Load (typeof(BibliotecaEN), id);
                session.Delete (bibliotecaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in BibliotecaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
