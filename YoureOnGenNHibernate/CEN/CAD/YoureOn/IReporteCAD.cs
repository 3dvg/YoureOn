
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IReporteCAD
{
ReporteEN ReadOIDDefault (int id
                          );

void ModifyDefault (ReporteEN reporte);



int New_ (ReporteEN reporte);

void Modify (ReporteEN reporte);


void Destroy (int id
              );
}
}
