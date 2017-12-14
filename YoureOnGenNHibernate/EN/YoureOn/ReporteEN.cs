
using System;
// Definición clase ReporteEN
namespace YoureOnGenNHibernate.EN.YoureOn
{
public partial class ReporteEN
{
/**
 *	Atributo id_reporte
 */
private int id_reporte;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;






public virtual int Id_reporte {
        get { return id_reporte; } set { id_reporte = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}





public ReporteEN()
{
}



public ReporteEN(int id_reporte, Nullable<DateTime> fecha
                 )
{
        this.init (Id_reporte, fecha);
}


public ReporteEN(ReporteEN reporte)
{
        this.init (Id_reporte, reporte.Fecha);
}

private void init (int id_reporte
                   , Nullable<DateTime> fecha)
{
        this.Id_reporte = id_reporte;


        this.Fecha = fecha;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ReporteEN t = obj as ReporteEN;
        if (t == null)
                return false;
        if (Id_reporte.Equals (t.Id_reporte))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id_reporte.GetHashCode ();
        return hash;
}
}
}
