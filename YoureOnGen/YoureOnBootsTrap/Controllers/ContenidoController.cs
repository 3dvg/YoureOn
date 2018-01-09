using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YoureOnGenNHibernate.CAD.YoureOn;
using YoureOnGenNHibernate.CEN.YoureOn;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.CP.YoureOn;
using WebApplication1.Models;
using YoureOnBootsTrap.Models;
using System.IO;
using Microsoft.AspNet.Identity;

namespace WebApplication1.Controllers
{
    public class ContenidoController : BasicController
    {
        // GET: Contenido
        public ActionResult Index()
        {
            return View();
        }

        // GET: Contenido/Details/5
        public ActionResult Details(int id)
        {
            SessionInitialize();
            ContenidoCAD contenidoCad = new ContenidoCAD(session);
            ContenidoEN contenidoEn = contenidoCad.ReadOIDDefault(id);

            ContenidoYComentarios contenido = new AssemblerContenido().ConvertENToModel(contenidoEn);

            SessionClose();

            //el contenido tiene que pasar a través del modelo
            return View(contenido);
        }

        [Authorize]
        // POST: Contenido/Comentar/5
        public ActionResult Comentar(int id, ContenidoYComentarios model)
        {
            SessionInitialize();
            ContenidoCAD contenidoCad = new ContenidoCAD(session);
            ContenidoEN contenidoEn = contenidoCad.ReadOIDDefault(id);
            UsuarioCAD usuarioCad = new UsuarioCAD(session);
            UsuarioCP usuario = new UsuarioCP(session);


            UsuarioEN user = usuarioCad.ReadOIDDefault(User.Identity.GetUserName());
            usuario.Comentar(user.Email, id, model.Comentar);
            ContenidoYComentarios contenido = new AssemblerContenido().ConvertENToModel(contenidoEn);

            SessionClose();

            return RedirectToAction("Details", "Contenido", new { id });
        }

        // GET: Contenido/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contenido/Create
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

        public ActionResult MostrarFotos()
        {
            SessionInitialize();
            ContenidoCAD contenidosCad = new ContenidoCAD(session);
            ContenidoCEN contenidosCen = new ContenidoCEN(contenidosCad);
            IList<ContenidoEN> contenidos = contenidosCen.DameContenidoPorFecha(DateTime.Today);

            IEnumerable<Contenido> listaContenidos = new AssemblerContenido().ConvertListENToModel(contenidos).ToList();
            for (int i = 0; i < listaContenidos.Count<Contenido>(); i++)
                if (listaContenidos.ElementAt<Contenido>(i) == null)
                    ViewData["Contenido"] = "Esto no funciona";
                else
                    ViewData["Contenido"] = listaContenidos.ElementAt<Contenido>(i).Ruta;

            SessionClose();
            return View(listaContenidos);
        }

        // GET: Contenido/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contenido/Edit/5
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

        // GET: Contenido/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contenido/Delete/5
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