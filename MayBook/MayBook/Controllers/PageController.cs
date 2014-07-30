using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MayBook.Controllers
{
    public class PageController : Controller
    {
        //
        // GET: /Page/

        public ActionResult Index(int id)
        {
            //var context = new MayBookDataContext();
            //var user = context.Users.Where(u => u.UserId == id).First();
            Models.Profile profile = new Models.Profile(id);
            ViewBag.Name = profile.User.Name;
            return View(profile);
        }

    }
}
