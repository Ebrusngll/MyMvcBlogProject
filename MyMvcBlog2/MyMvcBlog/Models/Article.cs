using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcBlog.Models
{
    public class Article
    {
        public Article()
        {
            
            this.ArticleAndTopics = new HashSet<ArticleAndTopic>();
        }

        public int ArticleId { get; set; }

        [Display(Name = "Tür")]
        //[Required(ErrorMessage = "Makalenin Türü zorunlu alandır.Lüten boş geçmeyiniz.")]
        public string Type { get; set; }


        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "Makakenin başlığı zorunlu alandır. Lütfen boş geçmeyiniz.")]
        public string Title { get; set; }


        [Display(Name = "İçerik")]
        [Required(ErrorMessage = "Makalenin İçeriği boş geçilemez.")]
        public string Content { get; set; }


        [Display(Name = "Kısa İçerik")]
        public string ContentTitle { get; set; }


        [Display(Name = "Fotoğraf")]
        public string Photo { get; set; }


        public DateTime DateOfWriting { get; set; }

        public int ReadingCount { get; set; } = 0;
        public int ReadingTime { get; set; }

        public int UserId { get; set; }
        public User user { get; set; }
        public ICollection<ArticleAndTopic> ArticleAndTopics { get; set; } // bir makalenin birden fazla konusu olabilir.

        

    }
}
