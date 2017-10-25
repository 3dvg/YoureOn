

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
 *      Definition of the class BibliotecaCEN
 *
 */
public partial class BibliotecaCEN
{
private IBibliotecaCAD _IBibliotecaCAD;

public BibliotecaCEN()
{
        this._IBibliotecaCAD = new BibliotecaCAD ();
}

public BibliotecaCEN(IBibliotecaCAD _IBibliotecaCAD)
{
        this._IBibliotecaCAD = _IBibliotecaCAD;
}

public IBibliotecaCAD get_IBibliotecaCAD ()
{
        return this._IBibliotecaCAD;
}

public int New_ (string p_usuario)
{
        BibliotecaEN bibliotecaEN = null;
        int oid;

        //Initialized BibliotecaEN
        bibliotecaEN = new BibliotecaEN ();

        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                bibliotecaEN.Usuario = new YoureOnGenNHibernate.EN.YoureOn.UsuarioEN ();
                bibliotecaEN.Usuario.Email = p_usuario;
        }

        //Call to BibliotecaCAD

        oid = _IBibliotecaCAD.New_ (bibliotecaEN);
        return oid;
}

public void Modify (int p_Biblioteca_OID)
{
        BibliotecaEN bibliotecaEN = null;

        //Initialized BibliotecaEN
        bibliotecaEN = new BibliotecaEN ();
        bibliotecaEN.Id = p_Biblioteca_OID;
        //Call to BibliotecaCAD

        _IBibliotecaCAD.Modify (bibliotecaEN);
}

public void Destroy (int id
                     )
{
        _IBibliotecaCAD.Destroy (id);
}
}
}
