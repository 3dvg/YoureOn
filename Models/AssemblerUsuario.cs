using YoureOnBootsTrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.Enumerated.YoureOn;
using System.Web.Mvc;
using WebApplication1.Models;
//using YoureOnGenNHibernate.EN.YoureOn.UsuarioEN;
//using WebApplication1.Models;


namespace YoureOnBootsTrap.Models
{
    public class AssemblerUsuario : Controller
    {
        public Usuario ConvertENToModelUI(UsuarioEN en)
        {
            Usuario usi = new Usuario();
            usi.Email = en.Email;
            usi.Nombre = en.Nombre;
            usi.Apellidos = en.Apellidos;
            usi.FechaNac = en.FechaNac;
            usi.NIF = en.NIF;
            usi.Foto = en.Foto;
            usi.Contrasenya = en.Contrasenya;

            return usi;


        }
        public IList<Usuario> ConvertListENToModel(IList<UsuarioEN> ens)
        {
            IList<Usuario> usus = new List<Usuario>();
            foreach (UsuarioEN en in ens)
            {
                usus.Add(ConvertENToModelUI(en));
            }
            return usus;
        }
    }
}
