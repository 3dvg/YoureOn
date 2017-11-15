
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using YoureOnGenNHibernate.Exceptions;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.CAD.YoureOn;
using YoureOnGenNHibernate.CEN.YoureOn;


namespace YoureOnGenNHibernate.CP.YoureOn
{
public partial class ReporteContenidoCP : BasicCP
{
public ReporteContenidoCP() : base ()
{
}

public ReporteContenidoCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
