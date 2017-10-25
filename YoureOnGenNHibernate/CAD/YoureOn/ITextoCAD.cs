
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface ITextoCAD
{
TextoEN ReadOIDDefault (string titulo
                        );

void ModifyDefault (TextoEN texto);



string New_ (TextoEN texto);

void Modify (TextoEN texto);


void Destroy (string titulo
              );
}
}
