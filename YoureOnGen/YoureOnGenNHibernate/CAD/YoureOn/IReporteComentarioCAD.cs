
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IReporteComentarioCAD
{
ReporteComentarioEN ReadOIDDefault (int id_reporte
                                    );

void ModifyDefault (ReporteComentarioEN reporteComentario);



int New_ (ReporteComentarioEN reporteComentario);

void Modify (ReporteComentarioEN reporteComentario);


void Destroy (int id_reporte
              );
}
}
