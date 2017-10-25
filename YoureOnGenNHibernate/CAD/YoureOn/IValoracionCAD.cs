
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IValoracionCAD
{
ValoracionEN ReadOIDDefault (string id
                             );

void ModifyDefault (ValoracionEN valoracion);



string New_ (ValoracionEN valoracion);

void Modify (ValoracionEN valoracion);


void Destroy (string id
              );
}
}
