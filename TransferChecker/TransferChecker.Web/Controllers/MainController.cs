﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TransferChecker.Model;
namespace TransferChecker.Web.Controllers
{
    public class MainController : Controller
    {
        private Entities db;
        public MainController()
        {
            db = new Entities();
        }

        public ActionResult Index()
        {
            return View(db);
        }


    }
}
