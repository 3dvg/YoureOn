
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IIdiomaCAD
{
IdiomaEN ReadOIDDefault (string idioma
                         );

void ModifyDefault (IdiomaEN idioma);



string New_ (IdiomaEN idioma);

void Modify (IdiomaEN idioma);


void Destroy (string idioma
              );
}
}
