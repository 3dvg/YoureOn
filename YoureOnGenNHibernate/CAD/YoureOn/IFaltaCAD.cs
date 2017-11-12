
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IFaltaCAD
{
FaltaEN ReadOIDDefault (string id
                        );

void ModifyDefault (FaltaEN falta);



string New_ (FaltaEN falta);

void Modify (FaltaEN falta);


void Destroy (string id
              );
}
}
