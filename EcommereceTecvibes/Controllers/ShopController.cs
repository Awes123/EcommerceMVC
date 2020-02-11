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
        public string changeproduct(int firstcatid)
        {
            var product = db.Products.Where(e => e.Category_ID == firstcatid).ToList();
            var returns = "";
            foreach(Product item in product)
            {
                returns += "<div class='col-lg-3 pt-2  pl-0 pr-0'><div class='card' style='width: 16rem;'><img src='/Media/Shop/Images/mobile-4596292_960_720.jpg' class='card-img-top' alt=''><div class='card-body text-center'><h5 class='card-title'>" + item.Product_Name + "</h5><p class='card-text'>" + item.Description.ToString().Substring(0, 40) + "</p><a href='javascript:void(0);' class='btn btn-primary Addtocart'><i class='fa fa-cart-plus'></i></a><a href='javascript:void(0);' class='btn btn-warning ml-1'><i class='fa fa-eye'></i></a></div></div></div>";
            }
            return returns;
}
        public bool CheckUser()
        {
            return User.Identity.IsAuthenticated?true:false;
        }
    }
}