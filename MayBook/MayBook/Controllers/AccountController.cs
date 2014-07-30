using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Web.Security;
using System.Security.Cryptography;
using System.Text;
namespace MayBook.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult LogOn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogOn(User user, string returnUrl)
        {
            var context = new MayBookDataContext();
            using (var md5 = MD5.Create())
            {
                var users = context.Users.Where(u => (u.Login.Trim() == user.Login) && (u.Password.Trim() == GetMd5Hash(md5, GetMd5Hash(md5, user.Password) + "MayBook")));
            
                if (users.Count() == 1)
                {
                    FormsAuthentication.SetAuthCookie(users.First().UserId.ToString(), true);
                    
                    return RedirectToAction("Index", "Page", new { id = users.First().UserId });
                    
                }
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }


        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            user.RegisterDate = DateTime.Now;
            using (var md5 = MD5.Create())
            {
                user.Password = GetMd5Hash(md5, GetMd5Hash(md5,user.Password) + "MayBook");
            }
            var context = new MayBookDataContext();
            context.Users.InsertOnSubmit(user);
            context.SubmitChanges();
            return RedirectToAction("Index", "Home");
        }


        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
