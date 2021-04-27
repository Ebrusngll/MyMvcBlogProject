using MyMvcBlog.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcBlog.Models
{
    public class User
    {
        public User()
        {
            this.UserAndTopics = new HashSet<UserAndTopic>();
        }
        public int UserId { get; set; }


        [Display(Name = "Ad Soyad")]
        
        public string FullName { get; set; }


        [Display(Name = "Kullanıcı Adı")]
        
        public string UserName { get; set; }


        [Display(Name = "Fotoğraf")]
        public string Photo { get; set; }


        [Required(ErrorMessage = "Mail alanı boş geçilemez.")]
        public string Mail { get; set; }


        [Display(Name = "Açıklama")]
        public string Description { get; set; }


        public string Url { get; set; }
        public UserRole UserRole { get; set; }
        public bool IsActive { get; set; }

       
        public ICollection<Article> Articles { get; set; }

        public ICollection<UserAndTopic> UserAndTopics { get; set; }

    }


}



