
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
public void Votar (int p_Contenido_OID, System.Collections.Generic.IList<int> p_valoracion_contenido_OIDs, int nota)
{
        /*PROTECTED REGION ID(YoureOnGenNHibernate.CEN.YoureOn_Contenido_votar) ENABLED START*/

        ValoracionContenidoEN valoracionContenidoEN = new ValoracionContenidoEN ();
        ContenidoEN contenidoEN = _IContenidoCAD.ReadOIDDefault (p_Contenido_OID);

        valoracionContenidoEN = new ValoracionContenidoEN (valoracionContenidoEN.Id_valoracion, contenidoEN, DateTime.Today, nota);

        /*PROTECTED REGION END*/
}
}
}
