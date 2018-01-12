using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.IO;
using Microsoft.AspNet.Identity;
using System.Reflection;
using System.Diagnostics;

using YoureOnBootsTrap.Models;
using YoureOnGenNHibernate.CAD.YoureOn;
using YoureOnGenNHibernate.CEN.YoureOn;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.Enumerated.YoureOn;
using YoureOnGenNHibernate.CP.YoureOn;

namespace YoureOnBootsTrap.Controllers
{
    public class ContenidoController : BasicController
    {
        [Authorize]
        public ActionResult Index()
        {
            IList<Contenido> lista = new List<Contenido>();

            SessionInitialize();
            UsuarioEN usuarioen = new UsuarioCAD(session).ReadOIDDefault(User.Identity.GetUserName());
            Usuario usu = new AssemblerUsuario().ConvertENToModelUI(usuarioen);

            if (usu.Contenidos != null)
            {
                // Copiamos los datos para la vista
                foreach (ContenidoEN f in usu.Contenidos)
                {
                    Contenido c = new AssemblerContenido().ConvertENToModelUI(f);
                    lista.Add(c);
                }
            }
            SessionClose();
            return View(lista);
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

            // Lista de Tipos de votos
            ViewBag.ListaEnum = ToListSelectListItem<PuntosVotoEnum>();

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
            int voto = Convert.ToInt32(Request.Form["votos"]);

            Debug.WriteLine(id);// id del contenido ej: 32768
            Debug.WriteLine(voto);// voto ej: 5

            //TODO..........................................................................

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
        public ActionResult Subir(Contenido cont)
        {
            try
            {
                if (Request.Files.Count > 0)
                {
                    var file = Request.Files[0];

                    if (file != null && file.ContentLength > 0)
                    {
                        string exte = Path.GetExtension(file.FileName).ToLower();

                        switch (exte)
                        {
                            case ".jpg":
                            case ".jpeg":
                            //case ".pjpeg":
                            //case ".gif":
                            case ".png":
                            case ".bmp":
                                /*case ".tif":
                                case ".mix":*/
                                cont.Tipo = TipoArchivoEnum.imagen;
                                break;

                            case ".avi":
                            case ".mp4":
                            case ".mpg":
                            case ".mpeg":
                            case ".mov":
                                /*case ".wmv":
                                 case ".flv":
                                 case ".rm":*/
                                cont.Tipo = TipoArchivoEnum.video;
                                break;

                            case ".wav":
                            case ".mp3":
                            case ".ogg":
                                //case ".midi":
                                cont.Tipo = TipoArchivoEnum.audio;
                                break;

                            case ".txt":
                            case ".doc":
                            case ".docx":
                            case ".pdf":
                            case ".rtf":
                                cont.Tipo = TipoArchivoEnum.texto;
                                break;
                            default:
                                return View();
                        }
                        
                        var fileName = Path.GetFileName(file.FileName);
                        var path = Path.Combine(Server.MapPath("~/Archivos/"), fileName);
                        file.SaveAs(path);
                        
                        cont.Autor = User.Identity.GetUserName();
                        cont.EnBibioteca = false;
                        cont.FCreacion = DateTime.Now;

                        ContenidoCAD cCAD = new ContenidoCAD();
                        ContenidoCEN cCEN = new ContenidoCEN(cCAD);

                        // Sale ObjectNotFoundException:

                        /*cCEN.SubirContenido("tit", TipoArchivoEnum.imagen, "Des",
                            TipoLicenciaEnum.CC_BY, "email", "autor",
                            false, "ruta", DateTime.Now);*/
                        /*cen.SubirContenido(cont.Titulo, cont.Tipo, cont.Descripcion,
                            cont.Licencia, cont.Autor, cont.Autor,
                            cont.EnBibioteca, cont.Ruta, cont.FCreacion);*/

                        Debug.WriteLine("Titulo: " + cont.Titulo);
                        Debug.WriteLine("Descripcion: " + cont.Descripcion);
                        Debug.WriteLine("Licencia: " + cont.Licencia);
                        Debug.WriteLine("Autor: " + cont.Autor);
                        Debug.WriteLine("EnBibioteca: " + cont.EnBibioteca);
                        Debug.WriteLine("FCreacion: " + cont.FCreacion);
                        Debug.WriteLine("-------------------------------------------------------");
                        Debug.WriteLine("Tipo: " + cont.Tipo);
                        Debug.WriteLine("File: " + fileName);
                        Debug.WriteLine("ext: " + exte);

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return View();
                    }
                } else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Buscar()
        {
            string titulo = Request.Form["titulo"];
            ViewBag.Titulo = titulo;
            IList<Contenido> lista = new List<Contenido>();

            if ((titulo != null) && (titulo != ""))
            {
                ContenidoCEN cen = new ContenidoCEN();
                foreach (ContenidoEN f in cen.DameContenidoPorTitulo(titulo))
                {
                    Contenido c = new AssemblerContenido().ConvertENToModelUI(f);
                    lista.Add(c);
                }
            }
            else
            {
                // devolver vista en la que se estaba
            }

            return View(lista);
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

            /* public ActionResult Edit()
             {*/
            /*int id = 32768;
            SessionInitialize();
            ContenidoEN usuarioen = new ContenidoCAD(session).ReadOIDDefault(id);
            Contenido usu = new AssemblerContenido().ConvertENToModelUI(usuarioen);
            SessionClose();
            return View(usu);*/
            /*return View();
        }*/

            // POST: Usuario/Editar
            /*[HttpPost]
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
            }*/

            // GET: Contenido/Delete/5
            /*public ActionResult Delete(int id)
            {
                return View();
            }*/

            // POST: Contenido/Delete/5
            /*[HttpPost]
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
            }*/


        [Authorize]
        public ActionResult Biblioteca()
        {
            IList<Contenido> lista = new List<Contenido>();

            SessionInitialize();
            UsuarioEN usuarioen = new UsuarioCAD(session).ReadOIDDefault(User.Identity.GetUserName());
            Usuario usu = new AssemblerUsuario().ConvertENToModelUI(usuarioen);

            if (usu.Biblioteca != null)
            {
                // Copiamos los datos para la vista
                foreach (ContenidoEN f in usu.Biblioteca)
                {
                    Contenido c = new AssemblerContenido().ConvertENToModelUI(f);
                    lista.Add(c);
                }
            }
            SessionClose();
            return View(lista);
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