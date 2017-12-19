
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.CAD.YoureOn;
using YoureOnGenNHibernate.CEN.YoureOn;



/*PROTECTED REGION ID(usingYoureOnGenNHibernate.CP.YoureOn_Contenido_reportar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace YoureOnGenNHibernate.CP.YoureOn
{
public partial class ContenidoCP : BasicCP
{
public void Reportar (int p_oid)
{
        /*PROTECTED REGION ID(YoureOnGenNHibernate.CP.YoureOn_Contenido_reportar) ENABLED START*/

        IContenidoCAD contenidoCAD = null;
        ContenidoCEN contenidoCEN = null;



        try
        {
                SessionInitializeTransaction ();
                contenidoCAD = new ContenidoCAD (session);
                contenidoCEN = new  ContenidoCEN (contenidoCAD);



                // Write here your custom transaction ...

                throw new NotImplementedException ("Method Reportar() not yet implemented.");



                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
