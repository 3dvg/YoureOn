

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

public string New_ (string p_id, Nullable<DateTime> p_fecha, float p_nota, string p_comentario)
{
        ValoracionComentarioEN valoracionComentarioEN = null;
        string oid;

        //Initialized ValoracionComentarioEN
        valoracionComentarioEN = new ValoracionComentarioEN ();
        valoracionComentarioEN.Id = p_id;

        valoracionComentarioEN.Fecha = p_fecha;

        valoracionComentarioEN.Nota = p_nota;


        if (p_comentario != null) {
                // El argumento p_comentario -> Property comentario es oid = false
                // Lista de oids id
                valoracionComentarioEN.Comentario = new YoureOnGenNHibernate.EN.YoureOn.ComentarioEN ();
                valoracionComentarioEN.Comentario.Id = p_comentario;
        }

        //Call to ValoracionComentarioCAD

        oid = _IValoracionComentarioCAD.New_ (valoracionComentarioEN);
        return oid;
}

public void Modify (string p_ValoracionComentario_OID, Nullable<DateTime> p_fecha, float p_nota)
{
        ValoracionComentarioEN valoracionComentarioEN = null;

        //Initialized ValoracionComentarioEN
        valoracionComentarioEN = new ValoracionComentarioEN ();
        valoracionComentarioEN.Id = p_ValoracionComentario_OID;
        valoracionComentarioEN.Fecha = p_fecha;
        valoracionComentarioEN.Nota = p_nota;
        //Call to ValoracionComentarioCAD

        _IValoracionComentarioCAD.Modify (valoracionComentarioEN);
}

public void Destroy (string id
                     )
{
        _IValoracionComentarioCAD.Destroy (id);
}
}
}
