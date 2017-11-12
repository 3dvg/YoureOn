
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IBibliotecaCAD
{
BibliotecaEN ReadOIDDefault (int id
                             );

void ModifyDefault (BibliotecaEN biblioteca);



int New_ (BibliotecaEN biblioteca);

void Modify (BibliotecaEN biblioteca);


void Destroy (int id
              );
}
}
