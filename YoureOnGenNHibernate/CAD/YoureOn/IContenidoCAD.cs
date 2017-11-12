
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IContenidoCAD
{
ContenidoEN ReadOIDDefault (string titulo
                            );

void ModifyDefault (ContenidoEN contenido);



string SubirContenido (ContenidoEN contenido);

void Editar (ContenidoEN contenido);


void Borrar (string titulo
             );




System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> DameContenidoPorTitulo (string arg0);
}
}
