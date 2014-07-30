using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
namespace MayBook.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            if (Request.IsAuthenticated)
            {
                int id = int.Parse(User.Identity.Name);
                return RedirectToAction("Index", "Page", new { id = id });
            }
            else
            {
                return RedirectToAction("LogOn", "Account");
            }
        }

    }
}
