using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using EcommereceTecvibes.Models;

namespace EcommereceTecvibes.Areas.Admin.Controllers
{
    public class DefaultController : Controller
    {
        EcommerceEntities db = new EcommerceEntities();
        [Authorize]
        public ActionResult Index()
        {
            var CurrentUser = User.Identity;
            return View();
        }
    }
}