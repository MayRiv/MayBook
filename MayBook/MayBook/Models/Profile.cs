using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MayBook.Models
{
    public class Profile
    {
        public IQueryable<Posts> Posts { get; private set; }
        public User User { get; private set; }
        public Profile(int id)
        {
            var context = new MayBookDataContext();
            User = context.Users.Where(u => u.UserId == id).First();
            Posts = context.Posts.Where(p => p.ReceiverId == id); 
        }
    }
}