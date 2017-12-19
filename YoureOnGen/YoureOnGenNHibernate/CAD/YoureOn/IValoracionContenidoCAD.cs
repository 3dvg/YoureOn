
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IValoracionContenidoCAD
{
ValoracionContenidoEN ReadOIDDefault (int id_valoracion
                                      );

void ModifyDefault (ValoracionContenidoEN valoracionContenido);



int New_ (ValoracionContenidoEN valoracionContenido);

void Modify (ValoracionContenidoEN valoracionContenido);


void Destroy (int id_valoracion
              );
}
}
