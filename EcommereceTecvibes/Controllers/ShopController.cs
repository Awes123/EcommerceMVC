using EcommereceTecvibes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommereceTecvibes.Controllers
{
    public class ShopController : Controller
    {
        EcommerceEntities db = new EcommerceEntities();
        // GET: Default
        public ActionResult Index()
        {
            List<Category> category = db.Categories.ToList();
            ViewBag.Category = category;
            var firstcatid = category.Select(s => s.Category_ID).FirstOrDefault();
            ViewBag.product = db.Products.Where(e=>e.Category_ID== firstcatid).ToList();
            return View();
        }
    }
}