using Microsoft.AspNetCore.Mvc;
using MyMvcBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcBlog.Views.Shared.Components.TopicControl
{
    public class TopicControlViewComponent : ViewComponent
    {
        private readonly MvcContext _mvcContext;
        public TopicControlViewComponent(MvcContext context)
        {
            _mvcContext = context;

        }
        public IViewComponentResult Invoke()
        {
            List<Topic> topics = _mvcContext.Topics.Select(a => new Topic { Photo = a.Photo , Title = a.Title , Description = a.Description}).ToList();
            return View(topics);
        }
    }
}
