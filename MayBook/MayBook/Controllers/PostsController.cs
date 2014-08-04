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
            using (var context = new MayBookDataContext())
            {
                Posts post = new Posts();
                post.Body = body;
                post.ReceiverId = receiverId;
                post.SenderId = int.Parse(User.Identity.Name);
                post.CreationDate = DateTime.Now;
                context.Posts.InsertOnSubmit(post);
                context.SubmitChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new MayBookDataContext())
            {
                context.Posts.DeleteOnSubmit(context.Posts.Where(p => p.PostId == id).First());
                context.SubmitChanges();
            }
            
        }
        public void Change(string body, int id)
        {
            using (var context = new MayBookDataContext())
            {
                var post = context.Posts.Where(p => p.PostId == id).First();
                post.Body = body.Trim();
                context.SubmitChanges();
            }
            
        }
        public ActionResult GetJSON(int receiverId)
        {
            using (var context = new MayBookDataContext())
            {
                var posts = context.Posts.Where(p => p.ReceiverId == receiverId);

                var answer = posts.Select(e => new
                {
                    e.SenderId,
                    e.Body,
                    e.CreationDate
                }).ToArray();
                
                return Json(answer, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
