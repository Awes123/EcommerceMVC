using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using EcommereceTecvibes.Models;

namespace EcommereceTecvibes.Controllers
{
    public class AdminController : Controller
    {
        EcommerceEntities db = new EcommerceEntities();
        [Authorize]
        //Dasboard
        public ActionResult Dashboard()
        {
            var CurrentUser = User.Identity;
            return View();
        }
        //Category
        [Authorize]
        public ActionResult Category()
        {
            return View();
        }
        
    }
}