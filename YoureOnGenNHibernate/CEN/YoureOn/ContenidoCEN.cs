

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
 *      Definition of the class ContenidoCEN
 *
 */
public partial class ContenidoCEN
{
private IContenidoCAD _IContenidoCAD;

public ContenidoCEN()
{
        this._IContenidoCAD = new ContenidoCAD ();
}

public ContenidoCEN(IContenidoCAD _IContenidoCAD)
{
        this._IContenidoCAD = _IContenidoCAD;
}

public IContenidoCAD get_IContenidoCAD ()
{
        return this._IContenidoCAD;
}

public string SubirContenido (string p_titulo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum p_tipoArchivo, string p_descripcion, string p_licencia, string p_usuario, string p_autor, bool p_enBiblioteca)
{
        ContenidoEN contenidoEN = null;
        string oid;

        //Initialized ContenidoEN
        contenidoEN = new ContenidoEN ();
        contenidoEN.Titulo = p_titulo;

        contenidoEN.TipoArchivo = p_tipoArchivo;

        contenidoEN.Descripcion = p_descripcion;

        contenidoEN.Licencia = p_licencia;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids titulo
                contenidoEN.Usuario = new YoureOnGenNHibernate.EN.YoureOn.UsuarioEN ();
                contenidoEN.Usuario.Email = p_usuario;
        }

        contenidoEN.Autor = p_autor;

        contenidoEN.EnBiblioteca = p_enBiblioteca;

        //edits
            contenidoEN.NumeroDeVotos = 0;
            contenidoEN.PuntuacionFinal = 0;
            contenidoEN.PuntuacionIndividual = 0;
        

        //Call to ContenidoCAD

        oid = _IContenidoCAD.SubirContenido (contenidoEN);
        return oid;
}

public void Editar (string p_Contenido_OID, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum p_tipoArchivo, string p_descripcion, string p_licencia, string p_autor, bool p_enBiblioteca)
{
        ContenidoEN contenidoEN = null;

        //Initialized ContenidoEN
        contenidoEN = new ContenidoEN ();
        contenidoEN.Titulo = p_Contenido_OID;
        contenidoEN.TipoArchivo = p_tipoArchivo;
        contenidoEN.Descripcion = p_descripcion;
        contenidoEN.Licencia = p_licencia;
        contenidoEN.Autor = p_autor;
        contenidoEN.EnBiblioteca = p_enBiblioteca;
        
        //Call to ContenidoCAD

        _IContenidoCAD.Editar (contenidoEN);
}

public void Borrar (string titulo
                    )
{
        _IContenidoCAD.Borrar (titulo);
}
public void Votar(int nota){
     ContenidoEN contenidoEN = null;
   // if(voto >= 0 && voto <= 5){
        contenidoEN.PuntuacionIndividual = (contenidoEN.PuntuacionIndividual + nota);
        contenidoEN.NumeroDeVotos = contenidoEN.NumeroDeVotos + 1;
        contenidoEN.PuntuacionFinal = contenidoEN.PuntuacionIndividual / contenidoEN.NumeroDeVotos;
   // }
}
public System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> DameContenidoPorTitulo (string c_titulo)
{
        return _IContenidoCAD.DameContenidoPorTitulo (c_titulo);
}
}
}
