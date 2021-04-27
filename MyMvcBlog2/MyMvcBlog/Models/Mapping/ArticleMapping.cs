using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcBlog.Models.Mapping
{
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.ArticleId);
            builder.Property(a => a.ArticleId).ValueGeneratedOnAdd();
            builder.Property(a => a.Content).IsRequired();
            builder.Property(a => a.Type).HasMaxLength(40);
            builder.Property(a => a.Title).HasMaxLength(40).IsRequired();


             builder.HasOne<User>(s => s.user)
             .WithMany(g => g.Articles)
             .HasForeignKey(s => s.UserId);

        }
    }
}
