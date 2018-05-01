using System.Threading.Tasks;
using CBA.AP.Blog.Domain.Repositories;
using CBA.AP.Blog.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CBA.AP.Blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogService blogService;

        public HomeController(IBlogService blogService)
        {
            this.blogService = blogService;
        }

        [HttpGet("/")]
        public async Task<IActionResult> Index()
        {
            var allPosts = await this.blogService.GetAsync();
            return View();
        }

        [HttpGet("/about")]
        public async Task<IActionResult> About()
        {
            return View();
        }
        
        [HttpGet("/contact")]
        public async Task<IActionResult> Contact()
        {
            return View();
        }
    }
}