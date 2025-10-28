using Domain.Entites;
using Infrastructure.Persistence.Emtities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Configurations
{
    internal sealed class BlogPostConfiguration : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Title)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(b => b.Content)
                   .IsRequired();

            builder.HasOne(b => b.Category)
                   .WithMany(c => c.BlogPosts)
                   .HasForeignKey(b => b.CategoryId);

            builder.HasMany(b => b.Comments)
                   .WithOne(c => c.Post)
                   .HasForeignKey(c => c.PostId);

            builder.HasOne(p => p.Category)
              .WithMany(c => c.BlogPosts)
              .HasForeignKey(p => p.CategoryId)
              .OnDelete(DeleteBehavior.Cascade);

            builder.Property(p => p.AuthorId)
       .HasMaxLength(450)
       .IsRequired();

          builder.HasIndex(p => p.AuthorId);
        }
    }
}
