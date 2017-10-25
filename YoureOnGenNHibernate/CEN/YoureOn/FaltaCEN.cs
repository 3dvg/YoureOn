

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
 *      Definition of the class FaltaCEN
 *
 */
public partial class FaltaCEN
{
private IFaltaCAD _IFaltaCAD;

public FaltaCEN()
{
        this._IFaltaCAD = new FaltaCAD ();
}

public FaltaCEN(IFaltaCAD _IFaltaCAD)
{
        this._IFaltaCAD = _IFaltaCAD;
}

public IFaltaCAD get_IFaltaCAD ()
{
        return this._IFaltaCAD;
}

public string New_ (string p_id, YoureOnGenNHibernate.Enumerated.YoureOn.TipoFaltaEnum p_tipoFalta, string p_usuario, Nullable<DateTime> p_fecha, string p_moderador)
{
        FaltaEN faltaEN = null;
        string oid;

        //Initialized FaltaEN
        faltaEN = new FaltaEN ();
        faltaEN.Id = p_id;

        faltaEN.TipoFalta = p_tipoFalta;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                faltaEN.Usuario = new YoureOnGenNHibernate.EN.YoureOn.UsuarioEN ();
                faltaEN.Usuario.Email = p_usuario;
        }

        faltaEN.Fecha = p_fecha;


        if (p_moderador != null) {
                // El argumento p_moderador -> Property moderador es oid = false
                // Lista de oids id
                faltaEN.Moderador = new YoureOnGenNHibernate.EN.YoureOn.ModeradorEN ();
                faltaEN.Moderador.Email = p_moderador;
        }

        //Call to FaltaCAD

        oid = _IFaltaCAD.New_ (faltaEN);
        return oid;
}

public void Modify (string p_Falta_OID, YoureOnGenNHibernate.Enumerated.YoureOn.TipoFaltaEnum p_tipoFalta, Nullable<DateTime> p_fecha)
{
        FaltaEN faltaEN = null;

        //Initialized FaltaEN
        faltaEN = new FaltaEN ();
        faltaEN.Id = p_Falta_OID;
        faltaEN.TipoFalta = p_tipoFalta;
        faltaEN.Fecha = p_fecha;
        //Call to FaltaCAD

        _IFaltaCAD.Modify (faltaEN);
}

public void Destroy (string id
                     )
{
        _IFaltaCAD.Destroy (id);
}
}
}
