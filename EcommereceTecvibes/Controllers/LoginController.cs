using EcommereceTecvibes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace EcommereceTecvibes.Controllers
{
    public class LoginController : Controller
    {

        EcommerceEntities db = new EcommerceEntities();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserDetail User, string ReturnUrl, string Password)
        {
            if (IsValid(User))
            {
                FormsAuthentication.SetAuthCookie(User.Username, false);
                return RedirectToAction("Index", "Default", new { area = "Admin" });
            }
            else
            {
                return View(User);
            }
        }

        private bool IsValid(UserDetail user)
        {
            //do DB work here
            UserDetail users = db.UserDetails.Where(e => e.Username == user.Username && e.Password == user.Password).FirstOrDefault();
            if (users != null)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return Redirect("/Login/Login");
        }
    }
}