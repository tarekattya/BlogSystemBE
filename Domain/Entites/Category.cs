﻿namespace Domain.Entites
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<BlogPost> BlogPosts { get; set; } = new List<BlogPost>();
    }
}