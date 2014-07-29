using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MayBook.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            MayBookDataContext context = new MayBookDataContext();
            var users = context.Users;
            foreach (var user in users)
                ViewBag.Name = user.Name;
            return View();
        }

    }
}
