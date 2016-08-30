using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofactory.Factories;
using Autofactory.Models;

namespace Autofactory.Controllers
{
    public class HomeController : Controller
    {
        ProductFactory productFac;
        CategoryFactory categoryFac;
        // GET: Home
        public ActionResult Index()
        {
            productFac = new ProductFactory();
            ViewBag.Exists = productFac.ExistsBy("Name", "nike shoE");
            return View();
        }
    }
}