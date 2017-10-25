

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

public string New_ (string p_titulo, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum p_tipoArchivo, string p_descripcion, string p_licencia, string p_usuario, string p_autor, bool p_enBiblioteca, Nullable<DateTime> p_duracion, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoAudioEnum p_formatoAudio)
{
        AudioEN audioEN = null;
        string oid;

        //Initialized AudioEN
        audioEN = new AudioEN ();
        audioEN.Titulo = p_titulo;

        audioEN.TipoArchivo = p_tipoArchivo;

        audioEN.Descripcion = p_descripcion;

        audioEN.Licencia = p_licencia;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids titulo
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

public void Modify (string p_Audio_OID, YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum p_tipoArchivo, string p_descripcion, string p_licencia, string p_autor, bool p_enBiblioteca, Nullable<DateTime> p_duracion, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoAudioEnum p_formatoAudio)
{
        AudioEN audioEN = null;

        //Initialized AudioEN
        audioEN = new AudioEN ();
        audioEN.Titulo = p_Audio_OID;
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

public void Destroy (string titulo
                     )
{
        _IAudioCAD.Destroy (titulo);
}
}
}
