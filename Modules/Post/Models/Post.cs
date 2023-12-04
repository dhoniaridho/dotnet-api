namespace IUJP.Modules.Post.Models
{
    public class PostModel
    {



        public string Id
        {
            get; set;
        }

        public required string Title
        {
            get; set;
        }

        public required DateTime CreatedAt
        {
            get; set;
        }

        public required DateTime UpdatedAt
        {
            get; set;
        }

        public PostModel()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}