
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface ITextoCAD
{
TextoEN ReadOIDDefault (int id_contenido
                        );

void ModifyDefault (TextoEN texto);



int New_ (TextoEN texto);

void Modify (TextoEN texto);


void Destroy (int id_contenido
              );
}
}
