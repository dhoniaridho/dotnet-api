using IUJP.Modules.Post.Services;
using Microsoft.AspNetCore.Mvc;
using UIJP.Modules.Post.Entities;

namespace IUJP.Modules.Post.Controller
{

    [ApiController]
    [Route("/posts")]
    public class PostController(IPostService postService) : ControllerBase
    {

        private readonly IPostService _postService = postService;


        [HttpGet("{id}")]
        public PostEntity Get(string id)
        {
            return _postService.GetOne(id);
        }

        [HttpGet]
        public IEnumerable<PostEntity> GetAll()
        {
            return _postService.GetAll();
        }
    }
}