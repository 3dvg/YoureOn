

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
 *      Definition of the class ComentarioCEN
 *
 */
public partial class ComentarioCEN
{
private IComentarioCAD _IComentarioCAD;

public ComentarioCEN()
{
        this._IComentarioCAD = new ComentarioCAD ();
}

public ComentarioCEN(IComentarioCAD _IComentarioCAD)
{
        this._IComentarioCAD = _IComentarioCAD;
}

public IComentarioCAD get_IComentarioCAD ()
{
        return this._IComentarioCAD;
}

public int New_ (string p_texto, Nullable<DateTime> p_fecha, string p_usuario, int p_contenido)
{
        ComentarioEN comentarioEN = null;
        int oid;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.Texto = p_texto;

        comentarioEN.Fecha = p_fecha;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id_comentario
                comentarioEN.Usuario = new YoureOnGenNHibernate.EN.YoureOn.UsuarioEN ();
                comentarioEN.Usuario.Email = p_usuario;
        }


        if (p_contenido != -1) {
                // El argumento p_contenido -> Property contenido es oid = false
                // Lista de oids id_comentario
                comentarioEN.Contenido = new YoureOnGenNHibernate.EN.YoureOn.ContenidoEN ();
                comentarioEN.Contenido.Id_contenido = p_contenido;
        }

        //Call to ComentarioCAD

        oid = _IComentarioCAD.New_ (comentarioEN);
        return oid;
}

public void Editar (int p_Comentario_OID, string p_texto, Nullable<DateTime> p_fecha)
{
        ComentarioEN comentarioEN = null;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.Id_comentario = p_Comentario_OID;
        comentarioEN.Texto = p_texto;
        comentarioEN.Fecha = p_fecha;
        //Call to ComentarioCAD

        _IComentarioCAD.Editar (comentarioEN);
}

public void Borrar (int id_comentario
                    )
{
        _IComentarioCAD.Borrar (id_comentario);
}
}
}
