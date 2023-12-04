using IUJP.Modules.Post.Models;
using IUJP.Modules.Post.Services;
using Microsoft.AspNetCore.Mvc;
using UIJP.Modules.Post.Dtos;
using UIJP.Modules.Post.Entities;

namespace IUJP.Modules.Post.Controller
{

    [ApiController]
    [Route("/posts")]
    public class PostController(IPostService postService) : ControllerBase
    {

        private readonly IPostService _postService = postService;


        [HttpGet("{id}")]
        public PostModel Get(string id)
        {
            return _postService.GetOne(id);
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