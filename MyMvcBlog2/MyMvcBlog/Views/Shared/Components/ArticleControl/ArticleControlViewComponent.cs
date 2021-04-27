using Microsoft.AspNetCore.Mvc;
using MyMvcBlog.Models;
using MyMvcBlog.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcBlog.Views.Shared.Components.ArticleControl
{
    public class ArticleControlViewComponent :ViewComponent
    {
        private readonly MvcContext _mvcContext;
        public ArticleControlViewComponent(MvcContext context)
        {
            _mvcContext = context;
            
        }
        public IViewComponentResult Invoke()
        {
            List<Article> articles = _mvcContext.Articles.Select(a => new Article { Content = a.Content, DateOfWriting = a.DateOfWriting,Title=a.Title}).ToList();
            return View();
        }
    }
}
