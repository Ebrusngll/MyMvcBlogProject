using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyMvcBlog.Models;
using MyMvcBlog.Models.DtoTables;
using MyMvcBlog.Models.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcBlog.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;
        private readonly MvcContext _mvcContext;
        TopicRepository topicRepository;
        Topic topic = new Topic();

        public HomeController(MvcContext context)
        {
            _mvcContext = context;
            topicRepository = new TopicRepository(context);
        }
        

        public IActionResult Details(int id)
        {
            return View(topicRepository.GetTopicId(id));
        }
        public IActionResult Index()
        {
            List<Topic> topicList = _mvcContext.Topics.Select(a => new Topic { TopicId = a.TopicId, Photo = a.Photo, Title = a.Title, Description = a.Description }).ToList();
            return View(topicList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
