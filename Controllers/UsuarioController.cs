using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.CEN.YoureOn;
using YoureOnGenNHibernate.CAD.YoureOn;
using WebApplication1.Models;
using YoureOnBootsTrap.Models;


namespace YoureOnBootsTrap.Controllers
{
    public class UsuarioController : BasicController
    {
        // GET: Usuario
        public ActionResult Index()
        {
            UsuarioCAD usu = new UsuarioCAD(session);
            //var result = evCEN.get_IEventoCAD();
            IEnumerable<UsuarioEN> list = usu.ReadAllDefault(0, int.MaxValue);
            return View(list);
        }

        // GET: Usuario/Details/email
        public ActionResult Details(String email)
        {
            SessionInitialize();
            UsuarioEN usuarioen = new UsuarioCAD(session).ReadOIDDefault(email);
            Usuario usu = new AssemblerUsuario().ConvertENToModelUI(usuarioen);
            SessionClose();
            return View(usu);
        }




        // GET: Usuario/Create
        public ActionResult Create()
        {
            //redirigir a accountController
            UsuarioEN en = new UsuarioEN();
            return View(en);
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                UsuarioCEN nuevousuario = new UsuarioCEN();

                //PD : VEIS , AQUI SE ASIGNA LA VARIABLE DE SESION, PORQUE CrearUser devuelve un id
                System.Web.HttpContext.Current.Session["Identificador"] = nuevousuario.CrearUsuario(p_email: collection["Email"], p_nombre: collection["Nombre"], p_apellidos: collection["Apellidos"], p_fechaNac: new DateTime(2011, 6, 10), p_NIF: collection["NIF"],
                    p_foto: "Foto", p_contrasenya: "1234Eva.", p_esVetado: false);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }





        // GET: Usuario/Edit/email
        public ActionResult Edit(String email)
        {

            SessionInitialize();
            UsuarioEN conEN = new UsuarioCAD(session).ReadOIDDefault(email);
            //com = new AssemblerUser().ConvertENToModelUI(conEN);
            SessionClose();
            return View(conEN);
        }

        // POST: Usuario/Edit/email
        [HttpPost]
        public ActionResult Edit(UsuarioEN u)
        {
            try
            {
                // TODO: Add update logic here
                UsuarioCEN cen = new UsuarioCEN();
                cen.EditarPerfil(u.Email, u.Nombre, u.Apellidos, u.FechaNac, u.NIF, u.Foto, u.Contrasenya, u.EsVetado);
                return RedirectToAction("Index", "Home");
                //return RedirectToAction("Index", "Home");
            }
            catch
            {

                return View();
            }
        }




        // GET: Usuario/Delete/email
        public ActionResult Delete(string email)
        {

            try
            {
                // TODO: Add delete logic here
                //int idCategoria = -1;
                SessionInitialize();
                UsuarioCAD artCAD = new UsuarioCAD(session);
                UsuarioCEN cen = new UsuarioCEN(artCAD);
                UsuarioEN artEN = cen.CargarPerfil(email);
                Usuario art = new AssemblerUsuario().ConvertENToModelUI(artEN);
                //idCategoria = art.IdCategoria;
                SessionClose();

                new UsuarioCEN().Destroy(email);

                //Request.Abort();
                //Session.Clear();
                //Session.Abandon();

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // POST: Usuario/Delete/email
        [HttpPost]
        public ActionResult Delete(string email, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }



    }
}
