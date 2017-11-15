

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
 *      Definition of the class AdministradorCEN
 *
 */
public partial class AdministradorCEN
{
private IAdministradorCAD _IAdministradorCAD;

public AdministradorCEN()
{
        this._IAdministradorCAD = new AdministradorCAD ();
}

public AdministradorCEN(IAdministradorCAD _IAdministradorCAD)
{
        this._IAdministradorCAD = _IAdministradorCAD;
}

public IAdministradorCAD get_IAdministradorCAD ()
{
        return this._IAdministradorCAD;
}

public string New_ (string p_email, string p_nombre, string p_apellidos, Nullable<DateTime> p_fechaNac, string p_NIF, string p_foto, String p_contrasenya, bool p_esVetado, string p_permisoModerador, string p_permisoAdministrador)
{
        AdministradorEN administradorEN = null;
        string oid;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();
        administradorEN.Email = p_email;

        administradorEN.Nombre = p_nombre;

        administradorEN.Apellidos = p_apellidos;

        administradorEN.FechaNac = p_fechaNac;

        administradorEN.NIF = p_NIF;

        administradorEN.Foto = p_foto;

        administradorEN.Contrasenya = Utils.Util.GetEncondeMD5 (p_contrasenya);

        administradorEN.EsVetado = p_esVetado;

        administradorEN.PermisoModerador = p_permisoModerador;

        administradorEN.PermisoAdministrador = p_permisoAdministrador;

        //Call to AdministradorCAD

        oid = _IAdministradorCAD.New_ (administradorEN);
        return oid;
}

public void Modify (string p_Administrador_OID, string p_nombre, string p_apellidos, Nullable<DateTime> p_fechaNac, string p_NIF, string p_foto, String p_contrasenya, bool p_esVetado, string p_permisoModerador, string p_permisoAdministrador)
{
        AdministradorEN administradorEN = null;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();
        administradorEN.Email = p_Administrador_OID;
        administradorEN.Nombre = p_nombre;
        administradorEN.Apellidos = p_apellidos;
        administradorEN.FechaNac = p_fechaNac;
        administradorEN.NIF = p_NIF;
        administradorEN.Foto = p_foto;
        administradorEN.Contrasenya = Utils.Util.GetEncondeMD5 (p_contrasenya);
        administradorEN.EsVetado = p_esVetado;
        administradorEN.PermisoModerador = p_permisoModerador;
        administradorEN.PermisoAdministrador = p_permisoAdministrador;
        //Call to AdministradorCAD

        _IAdministradorCAD.Modify (administradorEN);
}

public void Destroy (string email
                     )
{
        _IAdministradorCAD.Destroy (email);
}
}
}
