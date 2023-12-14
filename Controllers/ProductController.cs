using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CnC_Store.Models;

namespace CnC_Store.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index(int categoryId = 1)
        {
            BanhKeo_DBEntities dBContext = new BanhKeo_DBEntities();
            List<Product> Listproducts = dBContext.Products
                                        .Include(cat => cat.Category)
                                        .Where(pro => pro.CatId == categoryId).ToList();
            return View(Listproducts);
        }

        public ActionResult Detail(int id)
        {
            BanhKeo_DBEntities dBContext = new BanhKeo_DBEntities();
            Product product = dBContext.Products.Include(cat => cat.Category).FirstOrDefault(x => x.ProId == id);
            return View(product);
        }
    }
}