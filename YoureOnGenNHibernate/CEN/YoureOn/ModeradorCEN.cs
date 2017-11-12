

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
 *      Definition of the class ModeradorCEN
 *
 */
public partial class ModeradorCEN
{
private IModeradorCAD _IModeradorCAD;

public ModeradorCEN()
{
        this._IModeradorCAD = new ModeradorCAD ();
}

public ModeradorCEN(IModeradorCAD _IModeradorCAD)
{
        this._IModeradorCAD = _IModeradorCAD;
}

public IModeradorCAD get_IModeradorCAD ()
{
        return this._IModeradorCAD;
}

public string New_ (string p_email, string p_nombre, string p_apellidos, Nullable<DateTime> p_fechaNac, string p_NIF, string p_foto, String p_contrasenya, string p_valoracion, string p_permisoModerador)
{
        ModeradorEN moderadorEN = null;
        string oid;

        //Initialized ModeradorEN
        moderadorEN = new ModeradorEN ();
        moderadorEN.Email = p_email;

        moderadorEN.Nombre = p_nombre;

        moderadorEN.Apellidos = p_apellidos;

        moderadorEN.FechaNac = p_fechaNac;

        moderadorEN.NIF = p_NIF;

        moderadorEN.Foto = p_foto;

        moderadorEN.Contrasenya = Utils.Util.GetEncondeMD5 (p_contrasenya);


        if (p_valoracion != null) {
                // El argumento p_valoracion -> Property valoracion es oid = false
                // Lista de oids email
                moderadorEN.Valoracion = new YoureOnGenNHibernate.EN.YoureOn.ValoracionEN ();
                moderadorEN.Valoracion.Id = p_valoracion;
        }

        moderadorEN.PermisoModerador = p_permisoModerador;

        //Call to ModeradorCAD

        oid = _IModeradorCAD.New_ (moderadorEN);
        return oid;
}

public void Modify (string p_Moderador_OID, string p_nombre, string p_apellidos, Nullable<DateTime> p_fechaNac, string p_NIF, string p_foto, String p_contrasenya, string p_permisoModerador)
{
        ModeradorEN moderadorEN = null;

        //Initialized ModeradorEN
        moderadorEN = new ModeradorEN ();
        moderadorEN.Email = p_Moderador_OID;
        moderadorEN.Nombre = p_nombre;
        moderadorEN.Apellidos = p_apellidos;
        moderadorEN.FechaNac = p_fechaNac;
        moderadorEN.NIF = p_NIF;
        moderadorEN.Foto = p_foto;
        moderadorEN.Contrasenya = Utils.Util.GetEncondeMD5 (p_contrasenya);
        moderadorEN.PermisoModerador = p_permisoModerador;
        //Call to ModeradorCAD

        _IModeradorCAD.Modify (moderadorEN);
}

public void Destroy (string email
                     )
{
        _IModeradorCAD.Destroy (email);
}
}
}
