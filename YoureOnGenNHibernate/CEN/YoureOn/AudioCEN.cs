

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
 *      Definition of the class AudioCEN
 *
 */
public partial class AudioCEN
{
private IAudioCAD _IAudioCAD;

public AudioCEN()
{
        this._IAudioCAD = new AudioCAD ();
}

public AudioCEN(IAudioCAD _IAudioCAD)
{
        this._IAudioCAD = _IAudioCAD;
}

public IAudioCAD get_IAudioCAD ()
{
        return this._IAudioCAD;
}

public int New_ (string p_titulo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum p_tipoArchivo, string p_descripcion, string p_licencia, string p_usuario, string p_autor, bool p_enBiblioteca, Nullable<DateTime> p_duracion, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoAudioEnum p_formatoAudio)
{
        AudioEN audioEN = null;
        int oid;

        //Initialized AudioEN
        audioEN = new AudioEN ();
        audioEN.Titulo = p_titulo;

        audioEN.TipoArchivo = p_tipoArchivo;

        audioEN.Descripcion = p_descripcion;

        audioEN.Licencia = p_licencia;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id_contenido
                audioEN.Usuario = new YoureOnGenNHibernate.EN.YoureOn.UsuarioEN ();
                audioEN.Usuario.Email = p_usuario;
        }

        audioEN.Autor = p_autor;

        audioEN.EnBiblioteca = p_enBiblioteca;

        audioEN.Duracion = p_duracion;

        audioEN.FormatoAudio = p_formatoAudio;

        //Call to AudioCAD

        oid = _IAudioCAD.New_ (audioEN);
        return oid;
}

public void Modify (int p_Audio_OID, string p_titulo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum p_tipoArchivo, string p_descripcion, string p_licencia, string p_autor, bool p_enBiblioteca, Nullable<DateTime> p_duracion, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoAudioEnum p_formatoAudio)
{
        AudioEN audioEN = null;

        //Initialized AudioEN
        audioEN = new AudioEN ();
        audioEN.Id_contenido = p_Audio_OID;
        audioEN.Titulo = p_titulo;
        audioEN.TipoArchivo = p_tipoArchivo;
        audioEN.Descripcion = p_descripcion;
        audioEN.Licencia = p_licencia;
        audioEN.Autor = p_autor;
        audioEN.EnBiblioteca = p_enBiblioteca;
        audioEN.Duracion = p_duracion;
        audioEN.FormatoAudio = p_formatoAudio;
        //Call to AudioCAD

        _IAudioCAD.Modify (audioEN);
}

public void Destroy (int id_contenido
                     )
{
        _IAudioCAD.Destroy (id_contenido);
}
}
}
