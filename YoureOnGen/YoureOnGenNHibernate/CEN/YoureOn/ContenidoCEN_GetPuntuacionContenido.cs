
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


/*PROTECTED REGION ID(usingYoureOnGenNHibernate.CEN.YoureOn_Contenido_getPuntuacionContenido) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace YoureOnGenNHibernate.CEN.YoureOn
{
public partial class ContenidoCEN
{
public float GetPuntuacionContenido (int p_oid)
{
        /*PROTECTED REGION ID(YoureOnGenNHibernate.CEN.YoureOn_Contenido_getPuntuacionContenido) ENABLED START*/

        ContenidoEN contenido = _IContenidoCAD.ReadOIDDefault (p_oid);
        float mediaContenidos, sumaContenidos;

        sumaContenidos = mediaContenidos = 0;

        if (contenido != null)
                if (contenido.Valoracion_contenido.Count == 0) {
                        return mediaContenidos;
                }
                else{
                        System.Collections.Generic.IList<ValoracionContenidoEN> lista_valoraciones = contenido.Valoracion_contenido;


                        foreach (ValoracionContenidoEN val_contenido in lista_valoraciones) {
                                sumaContenidos += val_contenido.Nota;
                        }

                        mediaContenidos = sumaContenidos / lista_valoraciones.Count;
                }
        return mediaContenidos;

        /*PROTECTED REGION END*/
}
}
}
