using API_REST_NETCORE.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST_NETCORE.Controllers
{
    public class PostsController:Controller
    {
        private List<Post> _posts;
        public PostsController()
        {
            _posts = new List<Post>();
            for (int i = 0; i < 5; i++)
            {
                _posts.Add(new Post { Id = Guid.NewGuid().ToString() });
            }
        }


        [HttpGet("api/v1/posts")]
        public IActionResult GetAll()
        {
            return Ok(_posts);
        }
        //private List<Post> _posts;
        //
        //public PostsController()
        //{
        //    _posts = new List<Post>();
        //    for (var x=0;x<5;x++)
        //    {

        //    }
        //}
    }
}
