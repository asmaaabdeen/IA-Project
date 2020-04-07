using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using try_search.Models;

namespace try_search.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        
        public ActionResult Index(string search)
        {

            emarketEntities sd = new emarketEntities();
            List<pProduct> products = sd.pProducts.ToList();
            return View(sd.pProducts.Where(x=>x.cCategory.name.StartsWith(search)|| search== null).ToList());
        }
    }
}