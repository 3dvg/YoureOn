using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using YoureOnGenNHibernate.Enumerated.YoureOn;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnBootsTrap.Models
{
    public class Contenido
    {
        [Required(ErrorMessage = "Éste dato es requerido")]
        [DataType(DataType.Text)]
        [Display(Name = "Titulo")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Éste dato es requerido")]
        [DataType(DataType.Text)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Éste dato es requerido")]
        [Display(Name = "Licencia")]
        public TipoLicenciaEnum Licencia { get; set; }

        [ScaffoldColumn(false)]
        public int Id { get; set; }
       
        [Display(Name = "Tipo")]
        public TipoArchivoEnum Tipo { get; set; }
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