using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnBootsTrap.Models
{
    public class AssemblerContenidoYComentarios
    {
        public ContenidoYComentarios ConvertENToModel(ContenidoEN contenidoEN, float nota)
        {
            ContenidoYComentarios contenido = new ContenidoYComentarios();
            contenido.Id = contenidoEN.Id_contenido;
            contenido.Titulo = contenidoEN.Titulo;
            contenido.Tipo = contenidoEN.TipoArchivo;
            contenido.Descripcion = contenidoEN.Descripcion;
            contenido.Licencia = contenidoEN.Licencia;
            contenido.Autor = contenidoEN.Autor;
            contenido.EnBibioteca = contenidoEN.EnBiblioteca;
            contenido.Ruta = contenidoEN.Url;
            contenido.FCreacion = contenidoEN.FechaCreacion.Value;
            contenido.Valoracion = nota;
            //Debug.WriteLine(contenidoEN.Comentario.Count);
            if (contenidoEN.Comentario.Count > 0)
                contenido.ListaComentarios = contenidoEN.Comentario;

            return contenido;
        }
    }
}