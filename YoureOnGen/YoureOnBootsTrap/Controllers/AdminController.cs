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

            IList<FaltaEN> lista = new List<FaltaEN>();

            SessionInitialize();
            UsuarioEN usuarioen = new UsuarioCAD(session).ReadOIDDefault(email);
            Usuario usu = new AssemblerUsuario().ConvertENToModelUI(usuarioen);

            int contador = 0;
            // Copiamos los datos para la vista
            foreach (FaltaEN f in usu.Falta)
            {
                lista.Add(f);
                if (f.TipoFalta == TipoFaltaEnum.grave)
                    ViewBag.Grave = true;
                else
                {
                    ViewBag.Grave = false;
                    contador++;
                }
            }
            SessionClose();
            ViewBag.Email = email;
            ViewBag.ListaF = lista;
            ViewBag.Leve = contador;

            return View(usu);
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Create
        public ActionResult Create(string id)
        {
            ViewBag.cosa = id;

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
            FaltaCAD dirCAD = new FaltaCAD();
            dirCAD.Destroy(id);
            ViewBag.Id = id;
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

        // GET: Admin/BorrarPerfil/email
        public ActionResult BorrarPerfil(string email)
        {
            UsuarioCAD dirCAD = new UsuarioCAD();
            dirCAD.Destroy(email);
            return View();
        }
    }
}