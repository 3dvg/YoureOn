
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IBusquedaCAD
{
BusquedaEN ReadOIDDefault (int id
                           );

void ModifyDefault (BusquedaEN busqueda);



int New_ (BusquedaEN busqueda);

void Modify (BusquedaEN busqueda);


void Destroy (int id
              );
}
}
