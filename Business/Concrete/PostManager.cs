using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CrossCuttingConserns.Logging;

namespace Business.Concrete
{
    public class PostManager:IPostService

    {
        private readonly IPostDal _postDal;

        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }

        public bool AddUser(User user)
        {
            return _postDal.AddUser(user);
        }
        public bool AddPost(Post post)
        {
            return _postDal.AddPost(post);
        }

        public User FirstOrDefault(UserLoginDTO userLogin)
        {
            return _postDal.FirstOrDefault(userLogin);
        }
   
        public List<Post> GetAllPost()
        {
            return _postDal.GetAllPost();
        }


    }
}
