using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CnC_Store.Models;

namespace CnC_Store.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            BanhKeo_DBEntities dBContext = new BanhKeo_DBEntities();
            var Listproducts = dBContext.Product_Category;
            return View(Listproducts);
        }
    }
}