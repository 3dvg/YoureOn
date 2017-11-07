
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


/*PROTECTED REGION ID(usingYoureOnGenNHibernate.CEN.YoureOn_Moderador_poneFalta) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace YoureOnGenNHibernate.CEN.YoureOn
{
public partial class ModeradorCEN
{
public void PoneFalta (string p_oid, YoureOnGenNHibernate.Enumerated.YoureOn.TipoFaltaEnum tipoFalta, YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario, Nullable<DateTime> fechaFalta, YoureOnGenNHibernate.EN.YoureOn.ModeradorEN moderadorFalta)
{
        /*PROTECTED REGION ID(YoureOnGenNHibernate.CEN.YoureOn_Moderador_poneFalta) ENABLED START*/

        // Write here your custom code...
        Boolean creaFalta = false;
            if (p_oid != null) ;
           /* {
                if(p_oid!FaltaCAD.Equals)
            }*/
        FaltaEN faltaUsuario = new FaltaEN (p_oid, tipoFalta, usuario, fechaFalta, moderadorFalta);

        //throw new NotImplementedException ("Method PoneFalta() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
