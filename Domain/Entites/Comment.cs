namespace Domain.Entites
{
    public class Comment :BaseEntity
    {
        public string Content { get; set; } = string.Empty;

        public int PostId { get; set; }
        public BlogPost Post { get; set; }
    }
}