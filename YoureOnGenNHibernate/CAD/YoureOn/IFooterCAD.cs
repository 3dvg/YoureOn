
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IFooterCAD
{
FooterEN ReadOIDDefault (int id_footer
                         );

void ModifyDefault (FooterEN footer);



int New_ (FooterEN footer);

void Modify (FooterEN footer);


void Destroy (int id_footer
              );


System.Collections.Generic.IList<YoureOnGenNHibernate.EN.YoureOn.FooterEN> CargarEnlaces (int ? idEnlace);
}
}
