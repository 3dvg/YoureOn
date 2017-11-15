
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IVideoCAD
{
VideoEN ReadOIDDefault (int id_contenido
                        );

void ModifyDefault (VideoEN video);



int New_ (VideoEN video);

void Modify (VideoEN video);


void Destroy (int id_contenido
              );
}
}
