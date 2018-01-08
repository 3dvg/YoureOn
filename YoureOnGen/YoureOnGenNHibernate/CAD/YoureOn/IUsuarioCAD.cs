
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (string email
                          );

void ModifyDefault (UsuarioEN usuario);



string CrearUsuario (UsuarioEN usuario);

void EditarPerfil (UsuarioEN usuario);


void Destroy (string email
              );






UsuarioEN CargarPerfil (string email
                        );



System.Collections.Generic.IList<UsuarioEN> DameTodosLosUsuarios (int first, int size);
}
}
