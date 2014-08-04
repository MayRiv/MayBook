using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MayBook.Models
{
    public class Profile
    {
        public List<Posts> Posts { get; private set; }
        public User User { get; private set; }
        public int Page { get; private set; }
        public int NumberOfPages { get; private set; }
        private MayBookDataContext context;
        public Profile(int id, int page)
        {
            Page = page;
            context = new MayBookDataContext();
                User = context.Users.Where(u => u.UserId == id).First();

                Posts = context.Posts.Where(p => p.ReceiverId == id).OrderByDescending(p => p.CreationDate).Skip((Page - 1) * User.PostsNumber).Take(User.PostsNumber).ToList();
                var MyPostsCount = context.Posts.Where(p => p.ReceiverId == id).Count();
                NumberOfPages = MyPostsCount / User.PostsNumber;
                if ((MyPostsCount % User.PostsNumber) != 0)
                    NumberOfPages++;
            
        }
    }
}