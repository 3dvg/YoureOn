
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IReporeteContenidoCAD
{
ReporeteContenidoEN ReadOIDDefault (int id
                                    );

void ModifyDefault (ReporeteContenidoEN reporeteContenido);



int New_ (ReporeteContenidoEN reporeteContenido);

void Modify (ReporeteContenidoEN reporeteContenido);


void Destroy (int id
              );
}
}
