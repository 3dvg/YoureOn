using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YoureOnGenNHibernate.CAD.YoureOn;
using YoureOnGenNHibernate.CEN.YoureOn;
using YoureOnGenNHibernate.EN.YoureOn;
using WebApplication1.Models;


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
            return View();
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
            //IEnumerable<Contenido> listaContenidos = new AssemblerContenido().ConvertListEnToModel;
            SessionClose();
            return View(contenidos);
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
