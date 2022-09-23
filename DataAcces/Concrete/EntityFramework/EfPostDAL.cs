using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPostDAL : IPostDal
    {
        private PostContext postContext=new PostContext();
        
        public bool AddUser(User user)
        {
          postContext.User.Add(user);
          postContext.SaveChanges();
            return true;
        }
        public bool AddPost(Post post)
        {
            post.PostDate = DateTime.Now;
            postContext.Post.Add(post);
            postContext.SaveChanges();
            return true;
        }

        public User FirstOrDefault(UserLoginDTO userLogin)
        {
            var user= postContext.User.FirstOrDefault(x => x.UserMail == userLogin.UserEmail && x.UserPassword == userLogin.UserPassword);
            postContext.SaveChanges();
            return user;
          
        }

        public List<Post> GetAllPost()
        {
    
                var posts = postContext.Post.ToList();
                postContext.SaveChanges();
                return posts;
            
          
        }

   
    }
}
