using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcBlog.Models.DtoTables
{
    public class DtoMainPage
    {
        public DateTime DateOfWriting { get; set; }  // article
        public string Title { get; set; }  // article
        public string Photo { get; set; } // topic
        public string Description { get; set; }  //topic
    }
}
