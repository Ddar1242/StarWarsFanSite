﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarWarsFanSite.Controllers
{
    public class ShipsController : Controller
    {
        // GET: Ships
        public ActionResult Index()
        {
            return View();
        }
    }
}