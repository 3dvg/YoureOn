
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
 * Clase ValoracionComentario:
 *
 */

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial class ValoracionComentarioCAD : BasicCAD, IValoracionComentarioCAD
{
public ValoracionComentarioCAD() : base ()
{
}

public ValoracionComentarioCAD(ISession sessionAux) : base (sessionAux)
{
}



public ValoracionComentarioEN ReadOIDDefault (int id_valoracion
                                              )
{
        ValoracionComentarioEN valoracionComentarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                valoracionComentarioEN = (ValoracionComentarioEN)session.Get (typeof(ValoracionComentarioEN), id_valoracion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return valoracionComentarioEN;
}

public System.Collections.Generic.IList<ValoracionComentarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ValoracionComentarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ValoracionComentarioEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ValoracionComentarioEN>();
                        else
                                result = session.CreateCriteria (typeof(ValoracionComentarioEN)).List<ValoracionComentarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionComentarioCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ValoracionComentarioEN valoracionComentario)
{
        try
        {
                SessionInitializeTransaction ();
                ValoracionComentarioEN valoracionComentarioEN = (ValoracionComentarioEN)session.Load (typeof(ValoracionComentarioEN), valoracionComentario.Id_valoracion);

                session.Update (valoracionComentarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ValoracionComentarioEN valoracionComentario)
{
        try
        {
                SessionInitializeTransaction ();
                if (valoracionComentario.Comentario != null) {
                        // Argumento OID y no colección.
                        valoracionComentario.Comentario = (YoureOnGenNHibernate.EN.YoureOn.ComentarioEN)session.Load (typeof(YoureOnGenNHibernate.EN.YoureOn.ComentarioEN), valoracionComentario.Comentario.Id_comentario);

                        valoracionComentario.Comentario.Valoracion_comentario
                        .Add (valoracionComentario);
                }

                session.Save (valoracionComentario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return valoracionComentario.Id_valoracion;
}

public void Modify (ValoracionComentarioEN valoracionComentario)
{
        try
        {
                SessionInitializeTransaction ();
                ValoracionComentarioEN valoracionComentarioEN = (ValoracionComentarioEN)session.Load (typeof(ValoracionComentarioEN), valoracionComentario.Id_valoracion);

                valoracionComentarioEN.Fecha = valoracionComentario.Fecha;


                valoracionComentarioEN.Nota = valoracionComentario.Nota;

                session.Update (valoracionComentarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id_valoracion
                     )
{
        try
        {
                SessionInitializeTransaction ();
                ValoracionComentarioEN valoracionComentarioEN = (ValoracionComentarioEN)session.Load (typeof(ValoracionComentarioEN), id_valoracion);
                session.Delete (valoracionComentarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionComentarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
