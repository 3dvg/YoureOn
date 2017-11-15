
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



public ContenidoEN ReadOIDDefault (int id_contenido
                                   )
{
        ContenidoEN contenidoEN = null;

        try
        {
                SessionInitializeTransaction ();
                contenidoEN = (ContenidoEN)session.Get (typeof(ContenidoEN), id_contenido);
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
                ContenidoEN contenidoEN = (ContenidoEN)session.Load (typeof(ContenidoEN), contenido.Id_contenido);

                contenidoEN.Titulo = contenido.Titulo;


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


public int SubirContenido (ContenidoEN contenido)
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

        return contenido.Id_contenido;
}

public void Editar (ContenidoEN contenido)
{
        try
        {
                SessionInitializeTransaction ();
                ContenidoEN contenidoEN = (ContenidoEN)session.Load (typeof(ContenidoEN), contenido.Id_contenido);

                contenidoEN.Titulo = contenido.Titulo;


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
public void Borrar (int id_contenido
                    )
{
        try
        {
                SessionInitializeTransaction ();
                ContenidoEN contenidoEN = (ContenidoEN)session.Load (typeof(ContenidoEN), id_contenido);
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

//Sin e: CargarContenido
//Con e: ContenidoEN
public ContenidoEN CargarContenido (int id_contenido
                                    )
{
        ContenidoEN contenidoEN = null;

        try
        {
                SessionInitializeTransaction ();
                contenidoEN = (ContenidoEN)session.Get (typeof(ContenidoEN), id_contenido);
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

public System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> DameContenidoPorTitulo (string c_titulo)
{
        System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ContenidoEN self where FROM ContenidoEN as cont where cont.titulo = c_titulo;";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ContenidoENdameContenidoPorTituloHQL");
                query.SetParameter ("c_titulo", c_titulo);

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
