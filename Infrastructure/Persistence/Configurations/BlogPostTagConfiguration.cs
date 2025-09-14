using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Configurations
{
    internal sealed class BlogPostTagConfiguration : IEntityTypeConfiguration<BlogPostTag>
    {
        public void Configure(EntityTypeBuilder<BlogPostTag> builder)
        {
            builder.HasKey(bt => new { bt.BlogPostId, bt.TagId });

            builder.HasOne(bt => bt.BlogPost)
                   .WithMany(b => b.BlogPostTags)
                   .HasForeignKey(bt => bt.BlogPostId);

            builder.HasOne(bt => bt.Tag)
                   .WithMany(t => t.BlogPostTags)
                   .HasForeignKey(bt => bt.TagId);
        }
    }
}
