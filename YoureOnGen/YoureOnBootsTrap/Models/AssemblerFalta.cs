using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnBootsTrap.Models
{
    public class AssemblerFalta
    {
        public Falta ConvertENToModelUI(FaltaEN en)
        {
            Falta falta = new Falta();
            falta.Id_falta = en.Id_falta;
            falta.Fecha = en.Fecha;
            falta.TipoFalta = en.TipoFalta;
            falta.Usuario = en.Usuario;
            falta.Moderador = en.Moderador;

            return falta;
        }

        public IList<Falta> ConvertListENToModel(IList<FaltaEN> ens)
        {
            IList<Falta> faltas = new List<Falta>();
            foreach (FaltaEN en in ens)
            {
                faltas.Add(ConvertENToModelUI(en));
            }
            return faltas;
        }
    }
}