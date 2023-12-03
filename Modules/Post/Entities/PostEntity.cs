namespace UIJP.Modules.Post.Entities
{
    public class PostEntity
    {
        public required string Id { set; get; }
        public required string Title { set; get; }
        public required DateTime CreatedAt { set; get; }
    }
}