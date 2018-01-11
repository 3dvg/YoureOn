using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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
            IList<UsuarioEN> listaUsus = cen.DameTodosLosUsuarios(0, int.MaxValue);

            //Quitar admin y moderadores
            for(int i=0; i<listaUsus.Count; i++)
            {
                UsuarioEN u = listaUsus.ElementAt(i);

                if ((u.GetType() == typeof(AdministradorEN)) ||
                    (u.GetType() == typeof(ModeradorEN))) {
                    listaUsus.Remove(u);
                }
            }

            IEnumerable<Usuario> listArt = new AssemblerUsuario().ConvertListENToModel(listaUsus).ToList();

            return View(listArt);
        }

        public ActionResult VerFaltas(string email)
        {
            IList<FaltaEN> lista = new List<FaltaEN>();

            SessionInitialize();
            UsuarioEN usuarioen = new UsuarioCAD(session).ReadOIDDefault(email);
            Usuario usu = new AssemblerUsuario().ConvertENToModelUI(usuarioen);
            
            if (usu.Falta != null)
            {
                int contador = 0;
                ViewBag.Grave = false;

                // Copiamos los datos para la vista
                foreach (FaltaEN f in usu.Falta)
                {
                    lista.Add(f);
                    if (f.TipoFalta == TipoFaltaEnum.grave)
                    {
                        ViewBag.Grave = true;
                    }
                    else
                    {
                        contador++;
                    }
                }
                ViewBag.ListaF = lista;
                ViewBag.Leve = contador;
            }
            else
            {
                ViewBag.Leve = 0;
                ViewBag.Grave = false;
            }

            SessionClose();
            ViewBag.Email = email;
            ViewBag.Vetado = usu.EsVetado;

            // Lista de Tipos de faltas
            ViewBag.ListaEnum = ToListSelectListItem<TipoFaltaEnum>();

            return View(usu);
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(Usuario usu, FormCollection collection)
        {
            try
            {
                int dato = Convert.ToInt32(Request.Form["faltas"]);
                FaltaCAD faltaCAD = new FaltaCAD();
                FaltaCEN fCEN = new FaltaCEN(faltaCAD);

                switch(dato)
                {
                    case (int)TipoFaltaEnum.leve:
                        fCEN.New_(TipoFaltaEnum.leve, usu.Email, DateTime.Now, User.Identity.Name);
                        break;
                    case (int)TipoFaltaEnum.grave:
                        fCEN.New_(TipoFaltaEnum.grave, usu.Email, DateTime.Now, User.Identity.Name);
                        break;
                }

                return RedirectToAction("VerFaltas", new { email = usu.Email });
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
        public ActionResult Delete(int id, string em)
        {
            FaltaCAD dirCAD = new FaltaCAD();
            dirCAD.Destroy(id);
            return RedirectToAction("VerFaltas", new { email = em });
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

        // GET: Admin/VetarUsuario/email
        public ActionResult VetarUsuario(string email)
        {

            FaltaEN faltaGrave = null;

            SessionInitialize();
            UsuarioEN usuarioen = new UsuarioCAD(session).ReadOIDDefault(email);
            Usuario usu = new AssemblerUsuario().ConvertENToModelUI(usuarioen);

            // Copiamos la falta grave
            if (usu.Falta != null)
            {
                foreach (FaltaEN f in usu.Falta)
                {
                    if (f.TipoFalta == TipoFaltaEnum.grave)
                    {
                        faltaGrave = f;
                    }
                }
            }
            SessionClose();


            UsuarioCAD usuarioCad = new UsuarioCAD();
            UsuarioEN usuario = usuarioCad.ReadOIDDefault(email);

            if (usuario.EsVetado)
            {
                usuario.EsVetado = false;
                usu.EsVetado = false;
                if (faltaGrave != null)
                {
                    FaltaCAD dirCAD = new FaltaCAD();
                    dirCAD.Destroy(faltaGrave.Id_falta);
                }
            }
            else
            {
                usuario.EsVetado = true;
                usu.EsVetado = true;
            }

            usuarioCad.EditarPerfil(usuario);

            return RedirectToAction("VerFaltas", new { email = usu.Email });
        }
        
        // Para sacar los datos de un enum y meterlos en una lista
        private List<SelectListItem> ToListSelectListItem<T>()
        {
            var t = typeof(T);
            if (!t.IsEnum) { throw new ApplicationException("Tipo debe ser enum"); }
            var members = t.GetFields(BindingFlags.Public | BindingFlags.Static);

            var result = new List<SelectListItem>();
            foreach (var member in members)
            {
                var attributeDescription = member.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute),
                    false);
                var descripcion = member.Name;

                if (attributeDescription.Any())
                {
                    descripcion = ((System.ComponentModel.DescriptionAttribute)attributeDescription[0]).Description;
                }

                var valor = ((int)Enum.Parse(t, member.Name));
                result.Add(new SelectListItem()
                {
                    Text = descripcion,
                    Value = valor.ToString()
                });
            }
            return result;
        }
    }
}