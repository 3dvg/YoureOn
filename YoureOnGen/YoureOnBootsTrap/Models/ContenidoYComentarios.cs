using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.Enumerated.YoureOn;

namespace YoureOnBootsTrap.Models
{
    public class ContenidoYComentarios
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

        [DataType(DataType.Text)]
        [Display(Description = "Comentarios")]
        public string Comentarios { get; set; }

        [ScaffoldColumn(false)]
        public IList<ComentarioEN> ListaComentarios { get; set; }

        [Required(ErrorMessage = "Éste dato es requerido")]
        [DataType(DataType.Text)]
        [Display(Name = "Votar")]
        public string Votar { get; set; }

        [Required(ErrorMessage = "Éste dato es requerido")]
        [DataType(DataType.Text)]
        [Display(Name = "Comentarios")]
        public string Comentar { get; set; }
    }
}