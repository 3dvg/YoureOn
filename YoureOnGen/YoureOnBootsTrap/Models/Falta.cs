using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.Enumerated.YoureOn;

namespace YoureOnBootsTrap.Models
{
    public class Falta
    {
        [ScaffoldColumn(false)]
        public int Id_falta { get; set; }
        public TipoFaltaEnum TipoFalta { get; set; }
        [ScaffoldColumn(false)]
        public UsuarioEN Usuario { get; set; }
        [ScaffoldColumn(false)]
        public Nullable<DateTime> Fecha { get; set; }
        [ScaffoldColumn(false)]
        public ModeradorEN Moderador { get; set; }
    }
}