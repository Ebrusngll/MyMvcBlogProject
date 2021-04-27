using Microsoft.EntityFrameworkCore;
using MyMvcBlog.Models.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcBlog.Models
{
    public class MvcContext :DbContext
    {

        public MvcContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ArticleAndTopic> ArticleAndTopics { get; set; }
        //public DbSet<UserAndArticle> UserAndArticles { get; set; }
        public DbSet<UserAndTopic> UserAndTopics { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new ArticleAndTopicMapping());
            modelBuilder.ApplyConfiguration(new UserAndTopicMapping());
            modelBuilder.ApplyConfiguration(new ArticleMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new TopicMapping());

        }
    }
}
