
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IAudioCAD
{
AudioEN ReadOIDDefault (int id_contenido
                        );

void ModifyDefault (AudioEN audio);



int New_ (AudioEN audio);

void Modify (AudioEN audio);


void Destroy (int id_contenido
              );
}
}
