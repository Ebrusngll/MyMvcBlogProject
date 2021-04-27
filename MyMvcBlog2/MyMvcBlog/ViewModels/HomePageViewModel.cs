using MyMvcBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcBlog.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<Article> articles { get; set; }
        public IEnumerable<Topic> topics { get; set; }
    }
}
