using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YoureOnGenNHibernate.CAD.YoureOn;
using YoureOnGenNHibernate.CEN.YoureOn;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.CP.YoureOn;
using YoureOnGenNHibernate.Enumerated.YoureOn;
using WebApplication1.Models;
using YoureOnBootsTrap.Models;
using System.IO;
using Microsoft.AspNet.Identity;
using System.Reflection;

namespace YoureOnBootsTrap.Controllers
{
    public class ContenidoController : BasicController
    {
        // GET: Contenido
        public ActionResult Index()
        {
            return View();
        }
        //Débora: Detalle Foto
        // GET: Contenido/Details/5
        public ActionResult Details(int id)
        {
            SessionInitialize();
            ContenidoCAD contenidoCad = new ContenidoCAD(session);
            ContenidoEN contenidoEn = contenidoCad.ReadOIDDefault(id);

            ContenidoYComentarios contenido = new AssemblerContenidoYComentarios().ConvertENToModel(contenidoEn);

            SessionClose();

            //el contenido tiene que pasar a través del modelo
            return View(contenido);
        }
        //Débora: Comentar en detalle foto
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
            ContenidoYComentarios contenido = new AssemblerContenidoYComentarios().ConvertENToModel(contenidoEn);

            SessionClose();

            return RedirectToAction("Details", "Contenido", new { id });
        }
        
        public ActionResult Votar(int id)
        {
            // Lista de Tipos de faltas
            ViewBag.ListaEnum = ToListSelectListItem<PuntosVotoEnum>();
            return View();
        }

        // GET: Contenido/Create
        [Authorize]
        public ActionResult Subir()
        {
            // Lista de Tipos de licencias
            ViewBag.ListaEnum = ToListSelectListItem<TipoLicenciaEnum>();
            Contenido c = new Contenido();
            return View(c);
        }

        /// POST: Contenido/Create
        [HttpPost]
        [Authorize]
        public ActionResult Subir(Contenido cont, HttpPostedFileBase file)
        {
            string fileName = "", path = "";
            // Verify that the user selected a file
            if (file != null && file.ContentLength > 0)
            {
                // extract only the fielname
                fileName = Path.GetFileName(file.FileName);
                // store the file inside ~/App_Data/uploads folder
                path = Path.Combine(Server.MapPath("~/Archivos"), fileName);
                //string pathDef = path.Replace(@"\\", @"\");
                file.SaveAs(path);
            }

            try
            {
                fileName = "/Archivos/" + fileName;
                ContenidoCEN cen = new ContenidoCEN();

                /*cen.SubirContenido(cont.Titulo, cont.Tipo, cont.Descripcion,
                    cont.Licencia, User.Identity.GetUserName(), User.Identity.GetUserName(),
                    false, fileName, DateTime.Now);*/

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        /* Esto está en el index de index.cshtml
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
        }*/

        public ActionResult Edit()
        {
            /*int id = 32768;
            SessionInitialize();
            ContenidoEN usuarioen = new ContenidoCAD(session).ReadOIDDefault(id);
            Contenido usu = new AssemblerContenido().ConvertENToModelUI(usuarioen);
            SessionClose();
            return View(usu);*/
            return View();
        }

        // POST: Usuario/Editar
        [HttpPost]
        public ActionResult Edit(Contenido u)
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







        
        /*Eva
	public ActionResult Buscar(string contenido)
        {

            IEnumerable<ContenidoEN> list = null;
            IList<ContenidoEN> lista = new List<ContenidoEN>();
            ContenidoCEN conCEN = new ContenidoCEN();
            bool haentrao = false;
            SessionInitialize();
            if (contenido != null)
            {
                list = buscar_tipo(contenido);


            }
            SessionClose();

            if (haentrao == true && lista.Count < 1)
            {
                return RedirectToAction("Buscar", "usuario", routeValues: new { contenido });
            }
            else
            {
                return View(list);
            }
        }
        public IEnumerable<ContenidoEN> buscar_tipo(string contenido)
        {
            IEnumerable<ContenidoEN> list = null;
            ContenidoCEN evCEN = new ContenidoCEN();
            YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum preferencia;
            contenido = contenido.ToLower();
            if (contenido.Equals("texto"))
            {
                preferencia = YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum.texto;
                list = evCEN.ReadTipo(preferencia).ToList();
            }
            if (contenido == "imagen")
            {
                preferencia = YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum.imagen;
                list = evCEN.ReadTipo(preferencia).ToList();
            }

            if (contenido == "audio")
            {
                preferencia = YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum.audio;
                list = evCEN.ReadTipo(preferencia).ToList();
            }

            if (contenido == "video")
            {
                preferencia = YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum.video;
                list = evCEN.ReadTipo(preferencia).ToList();
            }
            return list;
        }*/
        
    }
}