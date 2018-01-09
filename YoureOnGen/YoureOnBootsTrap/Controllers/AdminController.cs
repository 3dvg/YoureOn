using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using YoureOnBootsTrap.Models;
using YoureOnGenNHibernate.CAD.YoureOn;
using YoureOnGenNHibernate.CEN.YoureOn;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.Enumerated.YoureOn;

namespace YoureOnBootsTrap.Controllers
{

    [Authorize(Roles = "Administrador, Moderador")]
    public class AdminController : BasicController
    {
        // GET: Admin
        public ActionResult Index()
        {
            UsuarioCEN cen = new UsuarioCEN();
            IList<UsuarioEN> listaUsus = cen.DameTodosLosUsuarios(0, 5);
            IEnumerable<Usuario> listArt = new AssemblerUsuario().ConvertListENToModel(listaUsus).ToList();

            return View(listArt);
        }

        public ActionResult VerFaltas(string email)
        {
            Debug.WriteLine(email);

            var faltas = new List<TipoFalta>();

            faltas.Add(new TipoFalta()
            {
                Descripcion = "Leve",
                Valor = TipoFaltaEnum.leve
            });

            faltas.Add(new TipoFalta()
            {
                Descripcion = "Grave",
                Valor = TipoFaltaEnum.grave
            });

            var list = new SelectList(faltas, "Descripcion", "Valor");
            ViewData["faltas"] = list;

            SessionInitialize();
            UsuarioEN usuarioen = new UsuarioCAD(session).ReadOIDDefault(email);
            Usuario usu = new AssemblerUsuario().ConvertENToModelUI(usuarioen);

            // No quitar
            Debug.WriteLine("");

            SessionClose();
            return View(usu);
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}