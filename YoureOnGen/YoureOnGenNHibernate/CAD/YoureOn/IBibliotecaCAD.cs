
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IBibliotecaCAD
{
BibliotecaEN ReadOIDDefault (int id_biblio
                             );

void ModifyDefault (BibliotecaEN biblioteca);



int New_ (BibliotecaEN biblioteca);

void Modify (BibliotecaEN biblioteca);


void Destroy (int id_biblio
              );



BibliotecaEN CargarBiblioteca (int id_biblio
                               );


System.Collections.Generic.IList<BibliotecaEN> OrdenarBiblioteca (int first, int size);
}
}
