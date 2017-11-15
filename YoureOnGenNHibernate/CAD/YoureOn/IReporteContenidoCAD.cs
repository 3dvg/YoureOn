
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IReporteContenidoCAD
{
ReporteContenidoEN ReadOIDDefault (int id_reporte
                                   );

void ModifyDefault (ReporteContenidoEN reporteContenido);



int New_ (ReporteContenidoEN reporteContenido);

void Modify (ReporteContenidoEN reporteContenido);


void Destroy (int id_reporte
              );
}
}
