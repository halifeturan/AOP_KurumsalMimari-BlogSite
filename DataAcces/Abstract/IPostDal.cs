using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IPostDal
    {
        List<Post> GetAllPost();
        public bool AddPost(Post post);
        public bool AddUser(User user);
        public User FirstOrDefault(UserLoginDTO userLogin);
    }
}
