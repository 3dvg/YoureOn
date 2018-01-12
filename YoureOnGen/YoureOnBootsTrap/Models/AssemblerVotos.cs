using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnBootsTrap.Models
{
    public class AssemblerVotos : Controller
    {
        public VotosContenidos ConvertENToModelUI(ValoracionContenidoEN valoracion)
        {
            VotosContenidos voto = new VotosContenidos();
            voto.id = valoracion.Id_valoracion;
            voto.Fecha = valoracion.Fecha;
            voto.Nota = valoracion.Nota;

            return voto;
        }

        public IList<VotosContenidos> ConvertListENToModel(IList<ValoracionContenidoEN> ens)
        {
            IList<VotosContenidos> votos = new List<VotosContenidos>();
            foreach (ValoracionContenidoEN en in ens)
            {
                votos.Add(ConvertENToModelUI(en));
            }
            return votos;
        }
    }
}
