
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IFooterCAD
{
FooterEN ReadOIDDefault (int id
                         );

void ModifyDefault (FooterEN footer);



int New_ (FooterEN footer);

void Modify (FooterEN footer);


void Destroy (int id
              );
}
}
