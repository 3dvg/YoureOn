
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
 * Clase ValoracionContenido:
 *
 */

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial class ValoracionContenidoCAD : BasicCAD, IValoracionContenidoCAD
{
public ValoracionContenidoCAD() : base ()
{
}

public ValoracionContenidoCAD(ISession sessionAux) : base (sessionAux)
{
}



public ValoracionContenidoEN ReadOIDDefault (string id
                                             )
{
        ValoracionContenidoEN valoracionContenidoEN = null;

        try
        {
                SessionInitializeTransaction ();
                valoracionContenidoEN = (ValoracionContenidoEN)session.Get (typeof(ValoracionContenidoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionContenidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return valoracionContenidoEN;
}

public System.Collections.Generic.IList<ValoracionContenidoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ValoracionContenidoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ValoracionContenidoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ValoracionContenidoEN>();
                        else
                                result = session.CreateCriteria (typeof(ValoracionContenidoEN)).List<ValoracionContenidoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionContenidoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ValoracionContenidoEN valoracionContenido)
{
        try
        {
                SessionInitializeTransaction ();
                ValoracionContenidoEN valoracionContenidoEN = (ValoracionContenidoEN)session.Load (typeof(ValoracionContenidoEN), valoracionContenido.Id);

                session.Update (valoracionContenidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionContenidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string New_ (ValoracionContenidoEN valoracionContenido)
{
        try
        {
                SessionInitializeTransaction ();
                if (valoracionContenido.Contenido != null) {
                        // Argumento OID y no colección.
                        valoracionContenido.Contenido = (YoureOnGenNHibernate.EN.YoureOn.ContenidoEN)session.Load (typeof(YoureOnGenNHibernate.EN.YoureOn.ContenidoEN), valoracionContenido.Contenido.Titulo);

                        valoracionContenido.Contenido.Valoracion_contenido
                        .Add (valoracionContenido);
                }

                session.Save (valoracionContenido);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionContenidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return valoracionContenido.Id;
}

public void Modify (ValoracionContenidoEN valoracionContenido)
{
        try
        {
                SessionInitializeTransaction ();
                ValoracionContenidoEN valoracionContenidoEN = (ValoracionContenidoEN)session.Load (typeof(ValoracionContenidoEN), valoracionContenido.Id);

                valoracionContenidoEN.Fecha = valoracionContenido.Fecha;


                valoracionContenidoEN.Nota = valoracionContenido.Nota;

                session.Update (valoracionContenidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionContenidoCAD.", ex);
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
                ValoracionContenidoEN valoracionContenidoEN = (ValoracionContenidoEN)session.Load (typeof(ValoracionContenidoEN), id);
                session.Delete (valoracionContenidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is YoureOnGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new YoureOnGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionContenidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
