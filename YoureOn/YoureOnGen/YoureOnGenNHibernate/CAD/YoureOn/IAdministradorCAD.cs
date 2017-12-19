
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IAdministradorCAD
{
AdministradorEN ReadOIDDefault (string email
                                );

void ModifyDefault (AdministradorEN administrador);



string New_ (AdministradorEN administrador);

void Modify (AdministradorEN administrador);


void Destroy (string email
              );
}
}
