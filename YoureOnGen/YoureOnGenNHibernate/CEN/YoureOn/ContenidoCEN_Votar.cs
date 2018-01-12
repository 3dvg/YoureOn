
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using YoureOnGenNHibernate.Exceptions;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.CAD.YoureOn;


/*PROTECTED REGION ID(usingYoureOnGenNHibernate.CEN.YoureOn_Contenido_votar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace YoureOnGenNHibernate.CEN.YoureOn
{
public partial class ContenidoCEN
{
public void Votar (int p_Contenido_OID, int nota)
{
        /*PROTECTED REGION ID(YoureOnGenNHibernate.CEN.YoureOn_Contenido_votar) ENABLED START*/

        ValoracionContenidoCEN valoracionContenido = new ValoracionContenidoCEN ();

        valoracionContenido.New_ (DateTime.Today, nota, p_Contenido_OID);

        /*PROTECTED REGION END*/
}
}
}
