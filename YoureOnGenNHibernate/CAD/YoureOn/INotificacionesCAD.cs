
using System;
using YoureOnGenNHibernate.EN.YoureOn;

namespace YoureOnGenNHibernate.CAD.YoureOn
{
public partial interface INotificacionesCAD
{
NotificacionesEN ReadOIDDefault (int id_notificacion
                                 );

void ModifyDefault (NotificacionesEN notificaciones);



int New_ (NotificacionesEN notificaciones);

void Modify (NotificacionesEN notificaciones);


void Destroy (int id_notificacion
              );
}
}
