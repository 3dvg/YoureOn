
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IFaltaCAD
{
FaltaEN ReadOIDDefault (int id_falta
                        );

void ModifyDefault (FaltaEN falta);



int New_ (FaltaEN falta);

void Modify (FaltaEN falta);


void Destroy (int id_falta
              );
}
}
