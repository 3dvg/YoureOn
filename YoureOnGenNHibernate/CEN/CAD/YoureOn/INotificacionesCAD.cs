
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface INotificacionesCAD
{
NotificacionesEN ReadOIDDefault (string id
                                 );

void ModifyDefault (NotificacionesEN notificaciones);



string New_ (NotificacionesEN notificaciones);

void Modify (NotificacionesEN notificaciones);


void Destroy (string id
              );
}
}
