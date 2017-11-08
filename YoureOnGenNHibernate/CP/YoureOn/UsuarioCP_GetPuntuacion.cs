
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.CAD.YoureOn;
using YoureOnGenNHibernate.CEN.YoureOn;



/*PROTECTED REGION ID(usingYoureOnGenNHibernate.CP.YoureOn_Usuario_getPuntuacion) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace YoureOnGenNHibernate.CP.YoureOn
{
public partial class UsuarioCP : BasicCP
{
public float GetPuntuacion (string p_oid)
{
        /*PROTECTED REGION ID(YoureOnGenNHibernate.CP.YoureOn_Usuario_getPuntuacion) ENABLED START*/

        IUsuarioCAD usuarioCAD = null;
        UsuarioCEN usuarioCEN = null;

        float result = 0;


        try
        {
                SessionInitializeTransaction ();
                usuarioCAD = new UsuarioCAD (session);
                usuarioCEN = new  UsuarioCEN (usuarioCAD);



                // Write here your custom transaction ...

                throw new NotImplementedException ("Method GetPuntuacion() not yet implemented.");



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
        return result;


        /*PROTECTED REGION END*/
}
}
}
