﻿using System.Web.Mvc;

namespace De_Gaverbeek.Controllers
{
    public class ProductenDetailsController : Controller
    {
        // GET: ProductenDetails

        public ActionResult Index(int id)
        {
            ViewBag.ID = id;
            return View();
        }
    }
}