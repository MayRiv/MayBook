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
        public PostsController()
        {
            context = new MayBookDataContext();
        }
        private MayBookDataContext context;
        public void Send(string body, int receiverId)
        {
            Posts post = new Posts();
            post.Body = body;
            post.ReceiverId = receiverId;
            post.SenderId = int.Parse(User.Identity.Name);
            post.CreationDate = DateTime.Now;
            context.Posts.InsertOnSubmit(post);
            context.SubmitChanges();
        }

        public void Delete(int id)
        {
            context.Posts.DeleteOnSubmit(context.Posts.Where(p => p.PostId == id).First());
            context.SubmitChanges();
            
        }
        public void Change(string body, int id)
        {
            var post = context.Posts.Where(p => p.PostId == id).First();
            post.Body = body;
            context.SubmitChanges();
        }

    }
}
