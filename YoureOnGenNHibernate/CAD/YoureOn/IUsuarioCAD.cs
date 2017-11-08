
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
        float GetPuntuacion(UsuarioEN usuarioEN);
    }
}
