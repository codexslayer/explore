using Explore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Explore.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /Users/
        ExploreDb _db = new ExploreDb();
        public ActionResult Login()
        {
            _db.Database.CreateIfNotExists();
            return View();
        }
        public ActionResult Validate(LoginModel login)
        {
            var query = _db.Users.Where(u => u.UserId == login.UserId).Where(u => u.Password == login.Password).FirstOrDefault();

            

            if (query == null)
            {
                ViewBag.Error = string.Format("Incorrect {0} or {1}", "UserId", "Password");
                return View("Login");
            }
            else
            {
                LoggedInUser user = new LoggedInUser();
                user.UserId = query.UserId;

                user.Name = query.Name;
                user.Active = query.Active;
                user.NeedPasswordChange = query.NeedPasswordChange;
                user.Department = query.Department;
                user.Designation = query.Designation;
                user.Mobile = query.Mobile;
                user.Email = query.Email;
                return View("LoggedIn", user);
            }
        }
        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
