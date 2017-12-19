
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IValoracionComentarioCAD
{
ValoracionComentarioEN ReadOIDDefault (int id_valoracion
                                       );

void ModifyDefault (ValoracionComentarioEN valoracionComentario);



int New_ (ValoracionComentarioEN valoracionComentario);

void Modify (ValoracionComentarioEN valoracionComentario);


void Destroy (int id_valoracion
              );
}
}
