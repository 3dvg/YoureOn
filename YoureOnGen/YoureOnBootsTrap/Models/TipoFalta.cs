using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YoureOnGenNHibernate.Enumerated.YoureOn;

namespace YoureOnBootsTrap.Models
{
    public class TipoFalta
    {
        public string Descripcion { get; set; }
        public TipoFaltaEnum Valor { get; set; }
    }
}