
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IYoureOnCAD
{
YoureOnEN ReadOIDDefault (int id
                          );

void ModifyDefault (YoureOnEN youreOn);



int New_ (YoureOnEN youreOn);

void Modify (YoureOnEN youreOn);


void Destroy (int id
              );
}
}
