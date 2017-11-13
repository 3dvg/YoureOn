
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


/*PROTECTED REGION ID(usingYoureOnGenNHibernate.CEN.YoureOn_Usuario_recuperarPassword) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace YoureOnGenNHibernate.CEN.YoureOn
{
public partial class UsuarioCEN
{
public string RecuperarPassword (string p_oid, string email)
{
            /*PROTECTED REGION ID(YoureOnGenNHibernate.CEN.YoureOn_Usuario_recuperarPassword) ENABLED START*/

            // Write here your custom code...

            string recuperar = null; //Error autenticacion

            if (p_oid != null && email != null)
            {
                UsuarioEN usuario = _IUsuarioCAD.ReadOIDDefault(p_oid);
                if (usuario != null && usuario.Email.Equals(email))
                {
                    // Generamos un numero aleatorio de 4cifras
                    Random random = new Random();
                    int numero = 0;
                    recuperar = "";

                    for (int i = 0; i<4; i++)
                    {
                        numero = random.Next(1, 10);
                        recuperar += numero;
                    }
                }
            }

            return recuperar;

            /*PROTECTED REGION END*/
        }
}
}
