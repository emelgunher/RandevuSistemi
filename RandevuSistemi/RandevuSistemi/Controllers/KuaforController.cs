﻿using RandevuSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RandevuSistemi.Controllers
{
    public class KuaforController : Controller
    {
        randevuEntities1 database = new randevuEntities1();
        // GET: Kuafor
        public ActionResult HizmetYonetimi()
        {
            return View();
        }

        public ActionResult OdemeAyarlari()
        {
            return View();
        }

        public ActionResult OnOdemeIsteme()
        {
            return View();
        }

        public ActionResult OnOdemeTalepEt()
        {
            return View();
        }


    }
}