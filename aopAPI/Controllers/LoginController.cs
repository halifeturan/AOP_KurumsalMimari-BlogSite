using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace aopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
  
    public class LoginController : ControllerBase
    {
        IPostService _postService = new PostManager(new EfPostDAL());
        readonly IConfiguration _configuration;
        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpPost("[action]")]
        public bool Create([FromForm] User User)
        {
            _postService.AddUser(User);
            return true;
        }
        
        [HttpPost("action")]
        public TokenDTO Login([FromForm] UserLoginDTO userLogin)
        {
            User user = _postService.FirstOrDefault(userLogin);
            if (user != null)
            {
                //Token üretiliyor.
                TokenHandler tokenHandler = new TokenHandler(_configuration);
                TokenDTO token = tokenHandler.CreateAccessToken(user);
                return token;
            }
            return null;
        }
    }
}
