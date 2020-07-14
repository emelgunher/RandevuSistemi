using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RandevuSistemi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Tanitim()
        {
            return View();
        }

        public ActionResult KayitOl()
        {
            return View();
        }

    }
}