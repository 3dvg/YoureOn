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

namespace WebApplication1.Controllers
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

            ContenidoYComentarios contenido = new AssemblerContenido().ConvertENToModel(contenidoEn);

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
            ContenidoYComentarios contenido = new AssemblerContenido().ConvertENToModel(contenidoEn);

            SessionClose();

            return RedirectToAction("Details", "Contenido", new { id });
        }
        
        public ActionResult Votar(int id)
        {
            var votos = new List<Votos>();

            votos.Add(new Votos()
            {
                Descripcion = "1",
                Valor = PuntosVotoEnum.uno
            });
            votos.Add(new Votos()
            {
                Descripcion = "2",
                Valor = PuntosVotoEnum.dos
            });
            votos.Add(new Votos()
            {
                Descripcion = "3",
                Valor = PuntosVotoEnum.tres
            });
            votos.Add(new Votos()
            {
                Descripcion = "4",
                Valor = PuntosVotoEnum.cuatro
            });
            votos.Add(new Votos()
            {
                Descripcion = "5",
                Valor = PuntosVotoEnum.cinco
            });
            votos.Add(new Votos()
            {
                Descripcion = "6",
                Valor = PuntosVotoEnum.seis
            });
            votos.Add(new Votos()
            {
                Descripcion = "7",
                Valor = PuntosVotoEnum.siete
            });
            votos.Add(new Votos()
            {
                Descripcion = "8",
                Valor = PuntosVotoEnum.ocho
            });
            votos.Add(new Votos()
            {
                Descripcion = "9",
                Valor = PuntosVotoEnum.nueve
            });
            votos.Add(new Votos()
            {
                Descripcion = "10",
                Valor = PuntosVotoEnum.diez
            });

            var list = new SelectList(votos, "Descripcion", "Valor");
            ViewData["votos"] = list;

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
        /*Eva a tocado los CEN manualmente cuando se debe hacer con el OOH4RIA
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