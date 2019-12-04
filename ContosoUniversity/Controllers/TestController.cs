using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Data;
using ContosoUniversity.Models.TestViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Controllers
{
    public class TestController : Controller
    {
        private readonly SchoolContext _context;

        public TestController(SchoolContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var article = new ArticleViewModel();
            article.AuthorName = "test123423134";
            article.Sections.Add(new ArticleSection() { Title = "title1213", Content = "content121323132" });
            return View(article);
        }
        
        [HttpPost]
        public string Test (string str)
        {
            return str + "11111";
        }
    }
}