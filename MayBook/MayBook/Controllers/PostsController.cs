using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MayBook.Controllers
{
    public class PostsController : Controller
    {
        //
        // GET: /Posts/

        public void Send(string body, int receiverId)
        {
            Posts post = new Posts();
            post.Body = body;
            post.ReceiverId = receiverId;
            post.SenderId = int.Parse(User.Identity.Name);
            post.CreationDate = DateTime.Now;
            var context = new MayBookDataContext();
            context.Posts.InsertOnSubmit(post);
            context.SubmitChanges();
        }

    }
}
