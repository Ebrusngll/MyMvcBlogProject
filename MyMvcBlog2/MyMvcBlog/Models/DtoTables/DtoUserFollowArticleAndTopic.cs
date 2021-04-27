using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcBlog.Models.DtoTables
{
    public class DtoUserFollowArticleAndTopic
    {
        public string FullName { get; set; } //user
        public string Title { get; set; } // topic
        public string Content { get; set; } // article
    }
}
