using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.Enumerated.YoureOn;

namespace WebApplication1.Models
{
    public class AssemblerContenido
    {       
        public Contenido ConvertENToModelUI(ContenidoEN contenidoEN)
        {
            Contenido contenido = new Contenido();
            contenido.Id = contenidoEN.Id_contenido;
            contenido.Titulo = contenidoEN.Titulo;
            contenido.Tipo = contenidoEN.TipoArchivo;
            contenido.Descripcion = contenidoEN.Descripcion;
            contenido.Licencia = contenidoEN.Licencia;
            contenido.Autor = contenidoEN.Autor;
            contenido.EnBibioteca = contenidoEN.EnBiblioteca;
            contenido.Ruta = contenidoEN.Url;
            contenido.FCreacion = contenidoEN.FechaCreacion.Value;

            return contenido;
        }
        public IList<Contenido> ConvertListENToModel(IList<ContenidoEN> contenidosEN)
        {
            IList<Contenido> contenidos = new List<Contenido>();
            foreach (ContenidoEN contenEn in contenidosEN)
            {
                contenidos.Add(ConvertENToModelUI(contenEn));
            }
            return contenidos;
        }
    }
}
