
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IComentarioCAD
{
ComentarioEN ReadOIDDefault (int id_comentario
                             );

void ModifyDefault (ComentarioEN comentario);



int New_ (ComentarioEN comentario);

void Editar (ComentarioEN comentario);


void Borrar (int id_comentario
             );
}
}
