
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


/*PROTECTED REGION ID(usingYoureOnGenNHibernate.CEN.YoureOn_Usuario_login) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace YoureOnGenNHibernate.CEN.YoureOn
{
public partial class UsuarioCEN
{
public int Login (string p_oid, String contrasenya)
{
            /*PROTECTED REGION ID(YoureOnGenNHibernate.CEN.YoureOn_Usuario_login) ENABLED START*/

            // Write here your custom code...

            int inicio = -1; //Error autenticacion

            if (p_oid != null && contrasenya != null)
            {
                UsuarioEN usuario = _IUsuarioCAD.ReadOIDDefault(p_oid);
                if (usuario != null && usuario.Contrasenya.Equals(Utils.Util.GetEncondeMD5(contrasenya)))
                {
                    /*if (usuario.esVetado)
                    {
                        inicio = 0; // Esta vetado
                    }
                    else */ if (usuario.GetType() == typeof(AdministradorEN))
                    {
                        inicio = 1; //Administrador
                    }
                    else if (usuario.GetType() == typeof(ModeradorEN))
                    {
                        inicio = 2; //Moderador
                    }
                    else
                    {
                        inicio = 3; //Registrado
                    }
                }
            }

            return inicio;

            /*PROTECTED REGION END*/
        }
}
}
