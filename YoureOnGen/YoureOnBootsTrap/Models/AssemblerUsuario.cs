using YoureOnBootsTrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.Enumerated.YoureOn;
using System.Web.Mvc;


namespace WebApplication1.Models
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
            usi.Falta = en.Falta;
            usi.Contenidos = en.Contenido;

            //Comentado ara que no pete al iniciar sesion con admin q no tiene, creo
            //usi.Biblioteca = en.Biblioteca.Contenido;

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

        internal IList<Contenido> ConvertBibliotecaENToModel(UsuarioEN usuarioen)
        {
            throw new NotImplementedException();
        }

        internal IList<Contenido> ConvertContenidosENToModel(UsuarioEN usuarioen)
        {
            throw new NotImplementedException();
        }
    }
}
