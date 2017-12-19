
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
public partial class ValoracionComentarioCP : BasicCP
{
public ValoracionComentarioCP() : base ()
{
}

public ValoracionComentarioCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
