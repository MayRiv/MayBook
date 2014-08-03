using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MayBook.App_Data
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/

        public ActionResult Index()
        {
            
            var context = new MayBookDataContext();
            var users = context.Users;
            return View(users);
        }

        [HttpPost]
        public ActionResult Index(string username)
        {
            if (username.Length == 0) return RedirectToAction("Index");
            var context = new MayBookDataContext();
            var users = context.Users.Where(u => u.Name == username);
            return View(users);
        }
    }
}
