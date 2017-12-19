

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using YoureOnGenNHibernate.Exceptions;

using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.CAD.YoureOn;


namespace YoureOnGenNHibernate.CEN.YoureOn
{
/*
 *      Definition of the class ValoracionComentarioCEN
 *
 */
public partial class ValoracionComentarioCEN
{
private IValoracionComentarioCAD _IValoracionComentarioCAD;

public ValoracionComentarioCEN()
{
        this._IValoracionComentarioCAD = new ValoracionComentarioCAD ();
}

public ValoracionComentarioCEN(IValoracionComentarioCAD _IValoracionComentarioCAD)
{
        this._IValoracionComentarioCAD = _IValoracionComentarioCAD;
}

public IValoracionComentarioCAD get_IValoracionComentarioCAD ()
{
        return this._IValoracionComentarioCAD;
}

public int New_ (Nullable<DateTime> p_fecha, int p_nota, int p_comentario)
{
        ValoracionComentarioEN valoracionComentarioEN = null;
        int oid;

        //Initialized ValoracionComentarioEN
        valoracionComentarioEN = new ValoracionComentarioEN ();
        valoracionComentarioEN.Fecha = p_fecha;

        valoracionComentarioEN.Nota = p_nota;


        if (p_comentario != -1) {
                // El argumento p_comentario -> Property comentario es oid = false
                // Lista de oids id_valoracion
                valoracionComentarioEN.Comentario = new YoureOnGenNHibernate.EN.YoureOn.ComentarioEN ();
                valoracionComentarioEN.Comentario.Id_comentario = p_comentario;
        }

        //Call to ValoracionComentarioCAD

        oid = _IValoracionComentarioCAD.New_ (valoracionComentarioEN);
        return oid;
}

public void Modify (int p_ValoracionComentario_OID, Nullable<DateTime> p_fecha, int p_nota)
{
        ValoracionComentarioEN valoracionComentarioEN = null;

        //Initialized ValoracionComentarioEN
        valoracionComentarioEN = new ValoracionComentarioEN ();
        valoracionComentarioEN.Id_valoracion = p_ValoracionComentario_OID;
        valoracionComentarioEN.Fecha = p_fecha;
        valoracionComentarioEN.Nota = p_nota;
        //Call to ValoracionComentarioCAD

        _IValoracionComentarioCAD.Modify (valoracionComentarioEN);
}

public void Destroy (int id_valoracion
                     )
{
        _IValoracionComentarioCAD.Destroy (id_valoracion);
}
}
}
