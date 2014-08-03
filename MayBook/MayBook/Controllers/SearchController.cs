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
            return View();
        }

        [HttpPost]
        public ActionResult Search(string username)
        {
            var context = new MayBookDataContext();
            var users = context.Users.Where(u => u.Name == username);
            return View(users);
        }
    }
}
