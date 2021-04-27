using Microsoft.AspNetCore.Mvc;
using MyMvcBlog.Models;
using MyMvcBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcBlog.Controllers
{
    public class HomePageViewModelController : Controller
    {
        private readonly MvcContext _context;

        public HomePageViewModelController(MvcContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomePageViewModel vm = new HomePageViewModel();
            vm.articles = _context.Articles.ToList();
            vm.topics = _context.Topics.ToList();
            return View(vm);
        }

        public IActionResult NewMemberPage()
        {
            HomePageViewModel vm = new HomePageViewModel();
            vm.articles = _context.Articles.ToList();
            vm.topics = _context.Topics.ToList();
            return View(vm);
        }
    }
}
