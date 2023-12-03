using Microsoft.CodeAnalysis.CSharp.Syntax;
using UIJP.Modules.Post.Entities;

namespace IUJP.Modules.Post.Services
{
    public interface IPostService
    {
        PostEntity GetOne(string id);
        IEnumerable<PostEntity> GetAll();
    }


    public class PostService : IPostService
    {
        public PostEntity GetOne(string id)
        {
            var post = new PostEntity
            {
                Id = id,
                Title = "Hello World",
                CreatedAt = DateTime.Now
            };
            return post;
        }

        public IEnumerable<PostEntity> GetAll()
        {

            var list = new List<PostEntity>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(new PostEntity
                {
                    Id = i.ToString(),
                    Title = "Hello World",
                    CreatedAt = DateTime.Now
                });
            }

            return list;
        }

    }
}

