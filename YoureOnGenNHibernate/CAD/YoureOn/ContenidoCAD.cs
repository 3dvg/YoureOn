
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
 * Clase Contenido:
 *
 */

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial class ContenidoCAD : BasicCAD, IContenidoCAD
{
public ContenidoCAD() : base ()
{
}

public ContenidoCAD(ISession sessionAux) : base (sessionAux)
{
}



public ContenidoEN ReadOIDDefault (string titulo
                                   )
{
        ContenidoEN contenidoEN = null;

        try
        {
                SessionInitializeTransaction ();
                contenidoEN = (ContenidoEN)session.Get (typeof(ContenidoEN), titulo);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ContenidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return contenidoEN;
}

public System.Collections.Generic.IList<ContenidoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ContenidoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ContenidoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ContenidoEN>();
                        else
                                result = session.CreateCriteria (typeof(ContenidoEN)).List<ContenidoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ContenidoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ContenidoEN contenido)
{
        try
        {
                SessionInitializeTransaction ();
                ContenidoEN contenidoEN = (ContenidoEN)session.Load (typeof(ContenidoEN), contenido.Titulo);

                contenidoEN.TipoArchivo = contenido.TipoArchivo;


                contenidoEN.Descripcion = contenido.Descripcion;


                contenidoEN.Licencia = contenido.Licencia;



                contenidoEN.Autor = contenido.Autor;





                contenidoEN.EnBiblioteca = contenido.EnBiblioteca;


                session.Update (contenidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ContenidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string SubirContenido (ContenidoEN contenido)
{
        try
        {
                SessionInitializeTransaction ();
                if (contenido.Usuario != null) {
                        // Argumento OID y no colección.
                        contenido.Usuario = (YoureOnGenNHibernate.EN.YoureOn.UsuarioEN)session.Load (typeof(YoureOnGenNHibernate.EN.YoureOn.UsuarioEN), contenido.Usuario.Email);

                        contenido.Usuario.Contenido
                        .Add (contenido);
                }

                session.Save (contenido);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ContenidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return contenido.Titulo;
}

public void Editar (ContenidoEN contenido)
{
        try
        {
                SessionInitializeTransaction ();
                ContenidoEN contenidoEN = (ContenidoEN)session.Load (typeof(ContenidoEN), contenido.Titulo);

                contenidoEN.TipoArchivo = contenido.TipoArchivo;


                contenidoEN.Descripcion = contenido.Descripcion;


                contenidoEN.Licencia = contenido.Licencia;


                contenidoEN.Autor = contenido.Autor;


                contenidoEN.EnBiblioteca = contenido.EnBiblioteca;

                session.Update (contenidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ContenidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Borrar (string titulo
                    )
{
        try
        {
                SessionInitializeTransaction ();
                ContenidoEN contenidoEN = (ContenidoEN)session.Load (typeof(ContenidoEN), titulo);
                session.Delete (contenidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ContenidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> DameContenidoPorTitulo (string arg0)
{
        System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ContenidoEN self where FROM ContenidoEN as cont where cont.titulo = c_titulo;";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ContenidoENdameContenidoPorTituloHQL");
                query.SetParameter ("arg0", arg0);

                result = query.List<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ContenidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
