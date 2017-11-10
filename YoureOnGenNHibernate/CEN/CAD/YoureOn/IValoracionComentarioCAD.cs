
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IValoracionComentarioCAD
{
ValoracionComentarioEN ReadOIDDefault (string id
                                       );

void ModifyDefault (ValoracionComentarioEN valoracionComentario);



string New_ (ValoracionComentarioEN valoracionComentario);

void Modify (ValoracionComentarioEN valoracionComentario);


void Destroy (string id
              );
}
}
