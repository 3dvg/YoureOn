using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
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
        
        public string Imagen { get; set; }

    }
}