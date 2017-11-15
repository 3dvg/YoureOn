
using System;
// Definición clase ValoracionContenidoEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class ValoracionContenidoEN                                                                  : YoureOnGenNHibernate.EN.YoureOn.ValoracionEN


{
/**
 *	Atributo contenido
 */
private YoureOnGenNHibernate.EN.YoureOn.ContenidoEN contenido;






public virtual YoureOnGenNHibernate.EN.YoureOn.ContenidoEN Contenido {
        get { return contenido; } set { contenido = value;  }
}





public ValoracionContenidoEN() : base ()
{
}



public ValoracionContenidoEN(int id_valoracion, YoureOnGenNHibernate.EN.YoureOn.ContenidoEN contenido
                             , Nullable<DateTime> fecha, int nota
                             )
{
        this.init (Id_valoracion, contenido, fecha, nota);
}


public ValoracionContenidoEN(ValoracionContenidoEN valoracionContenido)
{
        this.init (Id_valoracion, valoracionContenido.Contenido, valoracionContenido.Fecha, valoracionContenido.Nota);
}

private void init (int id_valoracion
                   , YoureOnGenNHibernate.EN.YoureOn.ContenidoEN contenido, Nullable<DateTime> fecha, int nota)
{
        this.Id_valoracion = id_valoracion;


        this.Contenido = contenido;

        this.Fecha = fecha;

        this.Nota = nota;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ValoracionContenidoEN t = obj as ValoracionContenidoEN;
        if (t == null)
                return false;
        if (Id_valoracion.Equals (t.Id_valoracion))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id_valoracion.GetHashCode ();
        return hash;
}
}
}
