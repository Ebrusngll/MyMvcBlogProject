using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcBlog.Models
{
    public class UserAndTopic
    {
        // user ve topic many to many ilişkisi için oluşturuldu.
        public int UserId { get; set; }
        public User User { get; set; }  // navigation prop.
        public int TopicId { get; set; }
        public Topic Topic { get; set; } // nav. prop.
    }
}
