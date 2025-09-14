namespace Domain.Entites
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<BlogPostTag> BlogPostTags { get; set; } = new List<BlogPostTag>();
    }
}