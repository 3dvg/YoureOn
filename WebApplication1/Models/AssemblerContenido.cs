using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.Enumerated.YoureOn;

namespace YoureOnBT.Models
{
    public class Contenido
    {
        int id;
        string titulo;
        TipoArchivoEnum tipo;
        string descripcion;
        TipoLicenciaEnum licencia;
        string autor;
        bool enBibioteca;
        string ruta;
        DateTime fCreacion;
        
        public Contenido ConvertENToModelUI(ContenidoEN contenidoEN)
        {
            Contenido contenido = new Contenido();
            contenido.id = contenidoEN.Id_contenido;
            contenido.titulo = contenidoEN.Titulo;
            contenido.tipo = contenidoEN.TipoArchivo;
            contenido.descripcion = contenidoEN.Descripcion;
            contenido.licencia = contenidoEN.Licencia;
            contenido.autor = contenidoEN.Autor;
            contenido.enBibioteca = contenidoEN.EnBiblioteca;
            contenido.ruta = contenidoEN.Url;
            contenido.fCreacion = contenidoEN.FechaCreacion.Value;

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
