

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
 *      Definition of the class UsuarioCEN
 *
 */
public partial class UsuarioCEN
{
private IUsuarioCAD _IUsuarioCAD;

public UsuarioCEN()
{
        this._IUsuarioCAD = new UsuarioCAD ();
}

public UsuarioCEN(IUsuarioCAD _IUsuarioCAD)
{
        this._IUsuarioCAD = _IUsuarioCAD;
}

public IUsuarioCAD get_IUsuarioCAD ()
{
        return this._IUsuarioCAD;
}

public string CrearUsuario (string p_email, string p_nombre, string p_apellidos, Nullable<DateTime> p_fechaNac, string p_NIF, string p_foto, String p_contrasenya)
{
        UsuarioEN usuarioEN = null;
        string oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Email = p_email;

        usuarioEN.Nombre = p_nombre;

        usuarioEN.Apellidos = p_apellidos;

        usuarioEN.FechaNac = p_fechaNac;

        usuarioEN.NIF = p_NIF;

        usuarioEN.Foto = p_foto;

        usuarioEN.Contrasenya = Utils.Util.GetEncondeMD5 (p_contrasenya);

        //Call to UsuarioCAD

        oid = _IUsuarioCAD.CrearUsuario (usuarioEN);
        return oid;
}

public void EditarPerfil (string p_Usuario_OID, string p_nombre, string p_apellidos, Nullable<DateTime> p_fechaNac, string p_NIF, string p_foto, String p_contrasenya)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Email = p_Usuario_OID;
        usuarioEN.Nombre = p_nombre;
        usuarioEN.Apellidos = p_apellidos;
        usuarioEN.FechaNac = p_fechaNac;
        usuarioEN.NIF = p_NIF;
        usuarioEN.Foto = p_foto;
        usuarioEN.Contrasenya = Utils.Util.GetEncondeMD5 (p_contrasenya);
        //Call to UsuarioCAD

        _IUsuarioCAD.EditarPerfil (usuarioEN);
}

public void Destroy (string email
                     )
{
        _IUsuarioCAD.Destroy (email);
}
}
}
