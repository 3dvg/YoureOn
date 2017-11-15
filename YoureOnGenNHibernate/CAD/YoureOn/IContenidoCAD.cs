
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IContenidoCAD
{
ContenidoEN ReadOIDDefault (int id_contenido
                            );

void ModifyDefault (ContenidoEN contenido);



int SubirContenido (ContenidoEN contenido);

void Editar (ContenidoEN contenido);


void Borrar (int id_contenido
             );



ContenidoEN CargarContenido (int id_contenido
                             );


System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.ContenidoEN> DameContenidoPorTitulo (string c_titulo);
}
}
