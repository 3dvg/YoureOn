
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IAudioCAD
{
AudioEN ReadOIDDefault (string titulo
                        );

void ModifyDefault (AudioEN audio);



string New_ (AudioEN audio);

void Modify (AudioEN audio);


void Destroy (string titulo
              );
}
}
