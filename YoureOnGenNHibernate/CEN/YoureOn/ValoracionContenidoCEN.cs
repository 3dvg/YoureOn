

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
 *      Definition of the class ValoracionContenidoCEN
 *
 */
public partial class ValoracionContenidoCEN
{
private IValoracionContenidoCAD _IValoracionContenidoCAD;

public ValoracionContenidoCEN()
{
        this._IValoracionContenidoCAD = new ValoracionContenidoCAD ();
}

public ValoracionContenidoCEN(IValoracionContenidoCAD _IValoracionContenidoCAD)
{
        this._IValoracionContenidoCAD = _IValoracionContenidoCAD;
}

public IValoracionContenidoCAD get_IValoracionContenidoCAD ()
{
        return this._IValoracionContenidoCAD;
}

public string New_ (string p_id, Nullable<DateTime> p_fecha, float p_nota, string p_contenido)
{
        ValoracionContenidoEN valoracionContenidoEN = null;
        string oid;

        //Initialized ValoracionContenidoEN
        valoracionContenidoEN = new ValoracionContenidoEN ();
        valoracionContenidoEN.Id = p_id;

        valoracionContenidoEN.Fecha = p_fecha;

        valoracionContenidoEN.Nota = p_nota;


        if (p_contenido != null) {
                // El argumento p_contenido -> Property contenido es oid = false
                // Lista de oids id
                valoracionContenidoEN.Contenido = new YoureOnGenNHibernate.EN.YoureOn.ContenidoEN ();
                valoracionContenidoEN.Contenido.Titulo = p_contenido;
        }

        //Call to ValoracionContenidoCAD

        oid = _IValoracionContenidoCAD.New_ (valoracionContenidoEN);
        return oid;
}

public void Modify (string p_ValoracionContenido_OID, Nullable<DateTime> p_fecha, float p_nota)
{
        ValoracionContenidoEN valoracionContenidoEN = null;

        //Initialized ValoracionContenidoEN
        valoracionContenidoEN = new ValoracionContenidoEN ();
        valoracionContenidoEN.Id = p_ValoracionContenido_OID;
        valoracionContenidoEN.Fecha = p_fecha;
        valoracionContenidoEN.Nota = p_nota;
        //Call to ValoracionContenidoCAD

        _IValoracionContenidoCAD.Modify (valoracionContenidoEN);
}

public void Destroy (string id
                     )
{
        _IValoracionContenidoCAD.Destroy (id);
}
}
}
