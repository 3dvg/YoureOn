using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YoureOnBootsTrap.Controllers
{
    public class FooterController : BasicController
    {
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Faqs()
        {
            return View();
        }

        public ActionResult Cookies()
        {
            return View();
        }

        public ActionResult Terminos()
        {
            return View();
        }

        public ActionResult Ayuda()
        {
            return View();
        }
    }
}