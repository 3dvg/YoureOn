
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
 * Clase Texto:
 *
 */

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial class TextoCAD : BasicCAD, ITextoCAD
{
public TextoCAD() : base ()
{
}

public TextoCAD(ISession sessionAux) : base (sessionAux)
{
}



public TextoEN ReadOIDDefault (int id_contenido
                               )
{
        TextoEN textoEN = null;

        try
        {
                SessionInitializeTransaction ();
                textoEN = (TextoEN)session.Get (typeof(TextoEN), id_contenido);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in TextoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return textoEN;
}

public System.Collections.Generic.IList<TextoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<TextoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(TextoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<TextoEN>();
                        else
                                result = session.CreateCriteria (typeof(TextoEN)).List<TextoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in TextoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (TextoEN texto)
{
        try
        {
                SessionInitializeTransaction ();
                TextoEN textoEN = (TextoEN)session.Load (typeof(TextoEN), texto.Id_contenido);

                textoEN.NumeroPaginas = texto.NumeroPaginas;

                session.Update (textoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in TextoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (TextoEN texto)
{
        try
        {
                SessionInitializeTransaction ();
                if (texto.Usuario != null) {
                        // Argumento OID y no colección.
                        texto.Usuario = (YoureOnGenNHibernate.EN.YoureOn.UsuarioEN)session.Load (typeof(YoureOnGenNHibernate.EN.YoureOn.UsuarioEN), texto.Usuario.Email);

                        texto.Usuario.Contenido
                        .Add (texto);
                }

                session.Save (texto);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in TextoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return texto.Id_contenido;
}

public void Modify (TextoEN texto)
{
        try
        {
                SessionInitializeTransaction ();
                TextoEN textoEN = (TextoEN)session.Load (typeof(TextoEN), texto.Id_contenido);

                textoEN.Titulo = texto.Titulo;


                textoEN.TipoArchivo = texto.TipoArchivo;


                textoEN.Descripcion = texto.Descripcion;


                textoEN.Licencia = texto.Licencia;


                textoEN.Autor = texto.Autor;


                textoEN.EnBiblioteca = texto.EnBiblioteca;


                textoEN.Url = texto.Url;


                textoEN.NumeroPaginas = texto.NumeroPaginas;

                session.Update (textoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in TextoCAD.", ex);
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
                TextoEN textoEN = (TextoEN)session.Load (typeof(TextoEN), id_contenido);
                session.Delete (textoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in TextoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
