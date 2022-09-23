using Business.Abstract;
using Business.Concrete;
using Core.CrossCuttingConserns.Logging;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace aopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class PostController : ControllerBase
    {    
        List<Post> posts = new List<Post>();
        IPostService _postService = new PostManager(new EfPostDAL());
        [HttpGet]

        public List<Post> Get()
        {

            
            foreach (var post in _postService.GetAllPost())
            {
                posts.Add(post);
            }
            return posts;
        }

        [HttpPost]
        public Post Post([FromForm] Post post)
        {

            _postService.AddPost(post);
            return post;
        }
    }
}
