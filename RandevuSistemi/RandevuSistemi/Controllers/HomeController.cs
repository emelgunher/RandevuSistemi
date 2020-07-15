using RandevuSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RandevuSistemi.Controllers
{
    public class HomeController : Controller
    {
        randevuEntities1 database = new randevuEntities1();
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