
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IVideoCAD
{
VideoEN ReadOIDDefault (string titulo
                        );

void ModifyDefault (VideoEN video);



string New_ (VideoEN video);

void Modify (VideoEN video);


void Destroy (string titulo
              );
}
}
