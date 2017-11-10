
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IModeradorCAD
{
ModeradorEN ReadOIDDefault (string email
                            );

void ModifyDefault (ModeradorEN moderador);



string New_ (ModeradorEN moderador);

void Modify (ModeradorEN moderador);


void Destroy (string email
              );
}
}
