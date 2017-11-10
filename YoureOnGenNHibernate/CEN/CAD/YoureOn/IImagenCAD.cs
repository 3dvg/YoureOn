
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IImagenCAD
{
ImagenEN ReadOIDDefault (string titulo
                         );

void ModifyDefault (ImagenEN imagen);



string New_ (ImagenEN imagen);

void Modify (ImagenEN imagen);


void Destroy (string titulo
              );
}
}
