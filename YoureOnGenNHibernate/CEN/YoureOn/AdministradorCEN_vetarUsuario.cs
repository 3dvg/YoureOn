
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


/*PROTECTED REGION ID(usingYoureOnGenNHibernate.CEN.YoureOn_Administrador_vetarUsuario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace YoureOnGenNHibernate.CEN.YoureOn
{
public partial class AdministradorCEN
{
public bool VetarUsuario (YoureOnGenNHibernate.EN.YoureOn.UsuarioEN usuario)
{
        /*PROTECTED REGION ID(YoureOnGenNHibernate.CEN.YoureOn_Administrador_vetarUsuario) ENABLED START*/

        bool vetado = false;

        if (usuario != null) {
                vetado = true;
                usuario.EsVetado = true;
        }
        return vetado;

        /*PROTECTED REGION END*/
}
}
}
