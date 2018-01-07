using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using YoureOnGenNHibernate.Enumerated.YoureOn;

namespace YoureOnBootsTrap.Models
{
    public class Contenido
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        public string Titulo { get; set; }
        [ScaffoldColumn(false)]
        public string Descripcion { get; set; }
        [ScaffoldColumn(false)]
        public TipoArchivoEnum Tipo { get; set; }
        [ScaffoldColumn(false)]
        public TipoLicenciaEnum Licencia { get; set; }
        [ScaffoldColumn(false)]
        public string Autor { get; set; }
        [ScaffoldColumn(false)]
        public bool EnBibioteca { get; set; }
        [ScaffoldColumn(false)]
        public string Ruta { get; set; }
        [ScaffoldColumn(false)]
        public DateTime FCreacion { get; set; }
    }
}