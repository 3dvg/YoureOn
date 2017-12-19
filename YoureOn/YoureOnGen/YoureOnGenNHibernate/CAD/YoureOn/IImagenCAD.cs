
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IImagenCAD
{
ImagenEN ReadOIDDefault (int id_contenido
                         );

void ModifyDefault (ImagenEN imagen);



int New_ (ImagenEN imagen);

void Modify (ImagenEN imagen);


void Destroy (int id_contenido
              );
}
}
