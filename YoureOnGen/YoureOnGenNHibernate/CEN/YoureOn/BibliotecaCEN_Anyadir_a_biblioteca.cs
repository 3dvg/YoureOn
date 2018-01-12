
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


/*PROTECTED REGION ID(usingYoureOnGenNHibernate.CEN.YoureOn_Biblioteca_anyadir_a_biblioteca) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace YoureOnGenNHibernate.CEN.YoureOn
{
public partial class BibliotecaCEN
{
public void Anyadir_a_biblioteca (int biblioteca_oid, YoureOnGenNHibernate.EN.YoureOn.ContenidoEN contenido)
{
            /*PROTECTED REGION ID(YoureOnGenNHibernate.CEN.YoureOn_Biblioteca_anyadir_a_biblioteca) ENABLED START*/

            // Write here your custom code...

            BibliotecaEN bibliotecaEN = _IBibliotecaCAD.CargarBiblioteca(biblioteca_oid);

            bibliotecaEN.Contenido.Add(contenido);


            _IBibliotecaCAD.Modify(bibliotecaEN);

            //throw new NotImplementedException ("Method Anyadir_a_biblioteca() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
