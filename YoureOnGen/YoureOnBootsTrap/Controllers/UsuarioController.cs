using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.CAD.YoureOn;
using YoureOnBootsTrap.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Globalization;
using System.Diagnostics;

namespace YoureOnBootsTrap.Controllers
{
    [Authorize]
    public class UsuarioController : BasicController
    {
        string rolPerfilPublico = "UsuarioPublico";
        string rolPerfilPrivado = "UsuarioPrivado";

        private string ObtenerRol()
        {
            if (User.IsInRole(rolPerfilPublico))
            {
                return "Público";
            }
            return "Privado";
        }
        // GET: Usuario
        public ActionResult Index()
        {
            string email = User.Identity.Name;
            SessionInitialize();
            UsuarioEN usuarioen = new UsuarioCAD(session).ReadOIDDefault(email);
            Usuario usu = new AssemblerUsuario().ConvertENToModelUI(usuarioen);
            usu.Perfil = ObtenerRol();
            SessionClose();
            return View(usu);
        }

        // GET: Usuario/Edit
        public ActionResult Edit()
        {
            string email = User.Identity.Name;
            SessionInitialize();
            UsuarioEN usuarioen = new UsuarioCAD(session).ReadOIDDefault(email);
            Usuario usu = new AssemblerUsuario().ConvertENToModelUI(usuarioen);
            usu.Perfil = ObtenerRol();
            ViewBag.Rol = usu.Perfil;

            // Cambiamos el formato a yyyy-MM-dd
            string fAux = usu.FechaNac.Value.Year.ToString("0000") + "-" +
                usu.FechaNac.Value.Month.ToString("00") + "-" +
                usu.FechaNac.Value.Day.ToString("00");
            ViewBag.Fecha = fAux;

            SessionClose();
            return View(usu);
        }

        // POST: Usuario/Editar
        [HttpPost]
        public ActionResult Edit(Usuario u)
        {
            try
            {
                UsuarioCAD usuarioCad = new UsuarioCAD();
                UsuarioEN usuario = usuarioCad.ReadOIDDefault(u.Email);
                usuario.Nombre = u.Nombre;
                usuario.Apellidos = u.Apellidos;
                usuario.NIF = u.NIF;

                // Fecha
                DateTime dt = Convert.ToDateTime(Request.Form["fecha"]);
                usuario.FechaNac = dt;
                
                usuarioCad.EditarPerfil(usuario);
                

                // Comprobamos si ha cambiado el rol
                if (!ObtenerRol().Equals(u.Perfil))
                {
                    ApplicationDbContext db = new ApplicationDbContext();
                    var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
                    string id = User.Identity.GetUserId();
                    // Cambiamos a privado
                    if (User.IsInRole(rolPerfilPublico))
                    {
                        userManager.RemoveFromRole(id, rolPerfilPublico);
                        userManager.AddToRole(id, rolPerfilPrivado);
                    }
                    else // Cambiamos a público
                    {
                        userManager.RemoveFromRole(User.Identity.GetUserId(), rolPerfilPrivado);
                        userManager.AddToRole(id, rolPerfilPublico);
                    }
                }
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: /Usuario/Delete
        public ActionResult Delete()
        {
            string email = User.Identity.Name;
            SessionInitialize();
            UsuarioEN usuarioen = new UsuarioCAD(session).ReadOIDDefault(email);
            Usuario usu = new AssemblerUsuario().ConvertENToModelUI(usuarioen);
            SessionClose();

            return View(usu);
        }

        // POST: /Usuario/Delete
        [HttpPost]
        public ActionResult Delete(Usuario usu)
        {
            try
            {
                // Borra la foto
                // System.IO.File.Delete(Server.MapPath("~" + usu.Foto));
                /*UsuarioCAD cen = new UsuarioCAD();
                cen.Destroy(usu.Email);

                Membership.DeleteUser(usu.Nombre);
                               
                FormsAuthentication.SignOut();
                Session.Abandon();*/

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
