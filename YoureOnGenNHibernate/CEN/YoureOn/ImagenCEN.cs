

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
 *      Definition of the class ImagenCEN
 *
 */
public partial class ImagenCEN
{
private IImagenCAD _IImagenCAD;

public ImagenCEN()
{
        this._IImagenCAD = new ImagenCAD ();
}

public ImagenCEN(IImagenCAD _IImagenCAD)
{
        this._IImagenCAD = _IImagenCAD;
}

public IImagenCAD get_IImagenCAD ()
{
        return this._IImagenCAD;
}

public int New_ (string p_titulo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum p_tipoArchivo, string p_descripcion, string p_licencia, string p_usuario, string p_autor, bool p_enBiblioteca, string p_url, Nullable<DateTime> p_fechaCreacion, int p_resolucion, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoImagenEnum p_formatoImagen)
{
        ImagenEN imagenEN = null;
        int oid;

        //Initialized ImagenEN
        imagenEN = new ImagenEN ();
        imagenEN.Titulo = p_titulo;

        imagenEN.TipoArchivo = p_tipoArchivo;

        imagenEN.Descripcion = p_descripcion;

        imagenEN.Licencia = p_licencia;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id_contenido
                imagenEN.Usuario = new YoureOnGenNHibernate.EN.YoureOn.UsuarioEN ();
                imagenEN.Usuario.Email = p_usuario;
        }

        imagenEN.Autor = p_autor;

        imagenEN.EnBiblioteca = p_enBiblioteca;

        imagenEN.Url = p_url;

        imagenEN.FechaCreacion = p_fechaCreacion;

        imagenEN.Resolucion = p_resolucion;

        imagenEN.FormatoImagen = p_formatoImagen;

        //Call to ImagenCAD

        oid = _IImagenCAD.New_ (imagenEN);
        return oid;
}

public void Modify (int p_Imagen_OID, string p_titulo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum p_tipoArchivo, string p_descripcion, string p_licencia, string p_autor, bool p_enBiblioteca, string p_url, Nullable<DateTime> p_fechaCreacion, int p_resolucion, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoImagenEnum p_formatoImagen)
{
        ImagenEN imagenEN = null;

        //Initialized ImagenEN
        imagenEN = new ImagenEN ();
        imagenEN.Id_contenido = p_Imagen_OID;
        imagenEN.Titulo = p_titulo;
        imagenEN.TipoArchivo = p_tipoArchivo;
        imagenEN.Descripcion = p_descripcion;
        imagenEN.Licencia = p_licencia;
        imagenEN.Autor = p_autor;
        imagenEN.EnBiblioteca = p_enBiblioteca;
        imagenEN.Url = p_url;
        imagenEN.FechaCreacion = p_fechaCreacion;
        imagenEN.Resolucion = p_resolucion;
        imagenEN.FormatoImagen = p_formatoImagen;
        //Call to ImagenCAD

        _IImagenCAD.Modify (imagenEN);
}

public void Destroy (int id_contenido
                     )
{
        _IImagenCAD.Destroy (id_contenido);
}
}
}
