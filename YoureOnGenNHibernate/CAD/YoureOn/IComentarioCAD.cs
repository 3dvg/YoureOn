
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IComentarioCAD
{
ComentarioEN ReadOIDDefault (string id
                             );

void ModifyDefault (ComentarioEN comentario);



string New_ (ComentarioEN comentario);

void Editar (ComentarioEN comentario);


void Borrar (string id
             );
}
}
