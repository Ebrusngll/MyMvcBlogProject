using Microsoft.AspNetCore.Mvc;
using MyMvcBlog.Models;
using MyMvcBlog.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcBlog.Controllers
{
    public class TopicController : Controller
    {
        private readonly MvcContext _mvcContext;
        UserRepository userRepository;
        public TopicController(MvcContext context)
        {
            this._mvcContext = context;
            userRepository = new UserRepository(context);   // repomu kullanabilmek için.
        }
        public IActionResult Index()
        {
            List<Topic> topicList = _mvcContext.Topics.Select(a => new Topic { TopicId = a.TopicId, Photo = a.Photo, Title = a.Title,Description=a.Description }).ToList();
            return View(topicList);
        }
    }
}
