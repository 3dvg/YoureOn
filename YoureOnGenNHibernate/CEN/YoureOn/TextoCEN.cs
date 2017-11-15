

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
 *      Definition of the class TextoCEN
 *
 */
public partial class TextoCEN
{
private ITextoCAD _ITextoCAD;

public TextoCEN()
{
        this._ITextoCAD = new TextoCAD ();
}

public TextoCEN(ITextoCAD _ITextoCAD)
{
        this._ITextoCAD = _ITextoCAD;
}

public ITextoCAD get_ITextoCAD ()
{
        return this._ITextoCAD;
}

public int New_ (string p_titulo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum p_tipoArchivo, string p_descripcion, string p_licencia, string p_usuario, string p_autor, bool p_enBiblioteca, int p_numeroPaginas)
{
        TextoEN textoEN = null;
        int oid;

        //Initialized TextoEN
        textoEN = new TextoEN ();
        textoEN.Titulo = p_titulo;

        textoEN.TipoArchivo = p_tipoArchivo;

        textoEN.Descripcion = p_descripcion;

        textoEN.Licencia = p_licencia;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id_contenido
                textoEN.Usuario = new YoureOnGenNHibernate.EN.YoureOn.UsuarioEN ();
                textoEN.Usuario.Email = p_usuario;
        }

        textoEN.Autor = p_autor;

        textoEN.EnBiblioteca = p_enBiblioteca;

        textoEN.NumeroPaginas = p_numeroPaginas;

        //Call to TextoCAD

        oid = _ITextoCAD.New_ (textoEN);
        return oid;
}

public void Modify (int p_Texto_OID, string p_titulo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum p_tipoArchivo, string p_descripcion, string p_licencia, string p_autor, bool p_enBiblioteca, int p_numeroPaginas)
{
        TextoEN textoEN = null;

        //Initialized TextoEN
        textoEN = new TextoEN ();
        textoEN.Id_contenido = p_Texto_OID;
        textoEN.Titulo = p_titulo;
        textoEN.TipoArchivo = p_tipoArchivo;
        textoEN.Descripcion = p_descripcion;
        textoEN.Licencia = p_licencia;
        textoEN.Autor = p_autor;
        textoEN.EnBiblioteca = p_enBiblioteca;
        textoEN.NumeroPaginas = p_numeroPaginas;
        //Call to TextoCAD

        _ITextoCAD.Modify (textoEN);
}

public void Destroy (int id_contenido
                     )
{
        _ITextoCAD.Destroy (id_contenido);
}
}
}
