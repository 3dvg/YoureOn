using MvcApplication1.Models;
using YoureOnBootsTrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.Enumerated.YoureOn;
using System.Web.Mvc;

namespace YoureOnBootsTrap.Models
{
    public class AssemblerAccount : Controller
    {
        public CompletarRegistro ConvertENToModelUI(UsuarioEN  usuarioEN)
        {
            CompletarRegistro completarRegistro = new CompletarRegistro();
            completarRegistro.Nombre = usuarioEN.Nombre;
            completarRegistro.Apellidos = usuarioEN.Apellidos;
            completarRegistro.Email = usuarioEN.Email;
            completarRegistro.FechaNacimiento = usuarioEN.FechaNac.Value;
            completarRegistro.NIF = usuarioEN.NIF;
            completarRegistro.Password = usuarioEN.Contrasenya;
            completarRegistro.ConfirmPassword = usuarioEN.Contrasenya;
            completarRegistro.FotoPerfil = usuarioEN.Foto;
            
            return completarRegistro;
        }
        //Genera una lista de los usuarios de la base de datos para consultarla (de momento para ver datos coincidentes que no deben coincidir)
        public IList<CompletarRegistro> ConvertListENToModel(IList<UsuarioEN> usuariosEN)
        {
            IList<CompletarRegistro> usuarios = new List<CompletarRegistro>();
            UsuarioEN usuarioEN = new UsuarioEN();
            int i = 0;
            while (i < usuariosEN.Count)
            {
                usuarioEN = usuariosEN.ElementAt(i);
                usuarios.Add(ConvertENToModelUI(usuarioEN));
                i++;
            }
            return usuarios;
        }
    }
}
