using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyMvcBlog.Models
{
    public class Topic
    {
        public Topic()
        {
            this.ArticleAndTopics = new HashSet<ArticleAndTopic>();
            this.UserAndTopics = new HashSet<UserAndTopic>();

        }
        public int TopicId { get; set; }


        [Display(Name = "Fotoğraf")]
        public string Photo { get; set; }


        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "Başlık Alanı boş geçilemez...")]
        public string Title { get; set; }

        public string Description { get; set; }

        public ICollection<ArticleAndTopic> ArticleAndTopics { get; set; }
        public ICollection<UserAndTopic> UserAndTopics { get; set; }

    }
}
