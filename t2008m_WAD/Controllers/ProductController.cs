using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using t2008m_WAD.Models;

namespace t2008m_WAD.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            SystemDbContext dc = new SystemDbContext();
            List<Product> products = dc.Products.ToList();
            return View(products);
        }

        public ActionResult GetProduct()
        {
         
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}