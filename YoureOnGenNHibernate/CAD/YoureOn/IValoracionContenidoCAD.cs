
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IValoracionContenidoCAD
{
ValoracionContenidoEN ReadOIDDefault (string id
                                      );

void ModifyDefault (ValoracionContenidoEN valoracionContenido);



string New_ (ValoracionContenidoEN valoracionContenido);

void Modify (ValoracionContenidoEN valoracionContenido);


void Destroy (string id
              );
}
}
