﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoComplete.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OtraPagina()
        {
            return new EmptyResult();
        }

        public ActionResult NuevaPagina()
        {
            return new EmptyResult();
        }
    }
}
