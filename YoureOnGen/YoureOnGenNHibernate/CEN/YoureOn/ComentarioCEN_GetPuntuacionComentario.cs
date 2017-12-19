
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


/*PROTECTED REGION ID(usingYoureOnGenNHibernate.CEN.YoureOn_Comentario_getPuntuacionComentario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace YoureOnGenNHibernate.CEN.YoureOn
{
public partial class ComentarioCEN
{
public float GetPuntuacionComentario (int p_oid)
{
        /*PROTECTED REGION ID(YoureOnGenNHibernate.CEN.YoureOn_Comentario_getPuntuacionComentario) ENABLED START*/

        // Write here your custom code...

        ComentarioEN comentario = _IComentarioCAD.ReadOIDDefault (p_oid);
        float mediaComentarios, sumaComentarios;

        sumaComentarios = mediaComentarios = 0;

        if (comentario != null) {
                System.Collections.Generic.IList<ValoracionComentarioEN> lista_valoraciones = comentario.Valoracion_comentario;


                foreach (ValoracionComentarioEN val_comentario in lista_valoraciones) {
                        sumaComentarios += val_comentario.Nota;
                }

                mediaComentarios = sumaComentarios / lista_valoraciones.Count;
        }
        return mediaComentarios;

        /*PROTECTED REGION END*/
}
}
}
