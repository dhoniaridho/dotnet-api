using System.Net;
using IUJP.Modules.Post.Models;
using IUJP.Modules.Post.Services;
using Microsoft.AspNetCore.Mvc;
using UIJP;
using UIJP.Modules.Post.Dtos;

namespace IUJP.Modules.Post.Controller
{

    [ApiController]
    [Route("/posts")]
    public class PostController(IPostService postService) : ControllerBase
    {

        private readonly IPostService _postService = postService;


        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var data = _postService.GetOne(id);

            if (data == null) return NotFound(
                new ResponsePipe(HttpStatusCode.NotFound, "Post not found")
            );

            return new ResponsePipe(HttpStatusCode.OK, "Success", data);
        }

        [HttpGet]
        public IEnumerable<PostModel> GetAll()
        {
            return _postService.GetAll();
        }

        [HttpPost]
        public PostModel CreateOne(CreatePostDto createPostDto)
        {
            return _postService.CreateOne(createPostDto);
        }

        [HttpDelete]
        public void DeleteOne(string id)
        {
            _postService.DeleteOne(id);
        }
    }
}