using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using YoureOnGenNHibernate.Enumerated.YoureOn;

namespace MvcApplication1.Models
{
    public class Contenido
    {
        [ScaffoldColumn(false)]
        public int Id { get; internal set; }
        [ScaffoldColumn(false)]
        public string Titulo { get; internal set; }
        [ScaffoldColumn(false)]
        public string Descripcion { get; internal set; }
        [ScaffoldColumn(false)]
        public TipoArchivoEnum Tipo { get; internal set; }
        [ScaffoldColumn(false)]
        public TipoLicenciaEnum Licencia { get; internal set; }
        [ScaffoldColumn(false)]
        public string Autor { get; internal set; }
        [ScaffoldColumn(false)]
        public bool EnBibioteca { get; internal set; }
        [ScaffoldColumn(false)]
        public string Ruta { get; internal set; }
        [ScaffoldColumn(false)]
        public DateTime FCreacion { get; internal set; }
    }
}