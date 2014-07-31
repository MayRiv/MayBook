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

        public ActionResult Index(int id, int postsPage=1)
        {
            //var context = new MayBookDataContext();
            //var user = context.Users.Where(u => u.UserId == id).First();
        //    return View(repository.Products
        //.OrderBy(p => p.ProductID)
        //.Skip((page - 1) * PageSize)
        //.Take(PageSize));

            Models.Profile profile = new Models.Profile(id,postsPage);
            ViewBag.Name = profile.User.Name;
            return View(profile);
        }

    }
}
