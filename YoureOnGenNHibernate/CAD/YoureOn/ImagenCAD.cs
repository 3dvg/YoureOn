
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
 * Clase Imagen:
 *
 */

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial class ImagenCAD : BasicCAD, IImagenCAD
{
public ImagenCAD() : base ()
{
}

public ImagenCAD(ISession sessionAux) : base (sessionAux)
{
}



public ImagenEN ReadOIDDefault (string titulo
                                )
{
        ImagenEN imagenEN = null;

        try
        {
                SessionInitializeTransaction ();
                imagenEN = (ImagenEN)session.Get (typeof(ImagenEN), titulo);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ImagenCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return imagenEN;
}

public System.Collections.Generic.IList<ImagenEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ImagenEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ImagenEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ImagenEN>();
                        else
                                result = session.CreateCriteria (typeof(ImagenEN)).List<ImagenEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ImagenCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ImagenEN imagen)
{
        try
        {
                SessionInitializeTransaction ();
                ImagenEN imagenEN = (ImagenEN)session.Load (typeof(ImagenEN), imagen.Titulo);

                imagenEN.Resolucion = imagen.Resolucion;


                imagenEN.FormatoImagen = imagen.FormatoImagen;

                session.Update (imagenEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ImagenCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string New_ (ImagenEN imagen)
{
        try
        {
                SessionInitializeTransaction ();
                if (imagen.Usuario != null) {
                        // Argumento OID y no colección.
                        imagen.Usuario = (YoureOnGenNHibernate.EN.YoureOn.UsuarioEN)session.Load (typeof(YoureOnGenNHibernate.EN.YoureOn.UsuarioEN), imagen.Usuario.Email);

                        imagen.Usuario.Contenido
                        .Add (imagen);
                }

                session.Save (imagen);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ImagenCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return imagen.Titulo;
}

public void Modify (ImagenEN imagen)
{
        try
        {
                SessionInitializeTransaction ();
                ImagenEN imagenEN = (ImagenEN)session.Load (typeof(ImagenEN), imagen.Titulo);

                imagenEN.TipoArchivo = imagen.TipoArchivo;


                imagenEN.Descripcion = imagen.Descripcion;


                imagenEN.Licencia = imagen.Licencia;


                imagenEN.Autor = imagen.Autor;


                imagenEN.EnBiblioteca = imagen.EnBiblioteca;


                imagenEN.Resolucion = imagen.Resolucion;


                imagenEN.FormatoImagen = imagen.FormatoImagen;

                session.Update (imagenEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ImagenCAD.", ex);
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
                ImagenEN imagenEN = (ImagenEN)session.Load (typeof(ImagenEN), titulo);
                session.Delete (imagenEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ImagenCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
