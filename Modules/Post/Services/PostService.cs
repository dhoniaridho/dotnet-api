using IUJP.Modules.Post.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using UIJP.Modules.Post.Dtos;


namespace IUJP.Modules.Post.Services
{
    public interface IPostService
    {
        PostModel? GetOne(string id);
        IEnumerable<PostModel> GetAll();
        PostModel CreateOne(CreatePostDto createPostDto);
        void DeleteOne(string id);
    }


    public class PostService(AppDbContext dbContext) : IPostService
    {

        private readonly AppDbContext _dbContext = dbContext;

        public PostModel? GetOne(string id)
        {
            var post = _dbContext.Posts.Where(x => x.Id == id).FirstOrDefault();
            if (post == null) return default;
            return post;
        }

        public IEnumerable<PostModel> GetAll()
        {

            var list = _dbContext.Posts.ToList();
            return list;
        }

        public PostModel CreateOne(CreatePostDto createPostDto)
        {
            var post = new PostModel
            {
                Title = createPostDto.Title,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            _dbContext.Posts.Add(
                post
            );

            _dbContext.SaveChanges();

            return post;
        }

        public void DeleteOne(string id)
        {
            var post = _dbContext.Posts.Where(x => x.Id == id).FirstOrDefault() ?? throw new Exception("Post not found");
            _dbContext.Posts.Remove(post);
            _dbContext.SaveChanges();
        }
    }
}

