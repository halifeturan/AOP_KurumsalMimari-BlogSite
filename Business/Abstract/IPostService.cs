using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPostService
    {
        List<Post> GetAllPost();
        public bool AddUser(User user);
        public bool AddPost(Post post);
        public User FirstOrDefault(UserLoginDTO userLogin);
    }
}
