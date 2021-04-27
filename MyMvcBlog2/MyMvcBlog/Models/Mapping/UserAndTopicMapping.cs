using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcBlog.Models.Mapping
{
    public class UserAndTopicMapping : IEntityTypeConfiguration<UserAndTopic>
    {
        public void Configure(EntityTypeBuilder<UserAndTopic> builder)
        {
            builder.HasKey(aa => new { aa.UserId, aa.TopicId });

            builder.HasOne<User>(aa => aa.User)
               .WithMany(a => a.UserAndTopics)
               .HasForeignKey(aa => aa.UserId);

            builder.HasOne<Topic>(aa => aa.Topic)
                .WithMany(a => a.UserAndTopics)
                .HasForeignKey(aa => aa.TopicId);

            // ilişkilerimi belirledim
        }
    }
}
