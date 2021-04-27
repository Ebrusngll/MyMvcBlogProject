using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcBlog.Models.Mapping
{
    public class ArticleAndTopicMapping : IEntityTypeConfiguration<ArticleAndTopic>
    {
        public void Configure(EntityTypeBuilder<ArticleAndTopic> builder)
        {
            builder.HasKey(aa => new { aa.ArticleId, aa.TopicId });

            builder.HasOne<Article>(aa => aa.Article)
               .WithMany(a => a.ArticleAndTopics)
               .HasForeignKey(aa => aa.ArticleId);

            builder.HasOne<Topic>(aa => aa.Topic)
                .WithMany(a => a.ArticleAndTopics)
                .HasForeignKey(aa => aa.TopicId);

            // ilişkilerimi belirledim
        }
    }
}
