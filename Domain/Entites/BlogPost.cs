using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Entites
{
    public class BlogPost : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;

        public PostStatus Status { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;
        public string AuthorId { get; set; } = string.Empty;


        public ICollection<BlogPostTag> BlogPostTags { get; set; } = new List<BlogPostTag>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

    }
}

