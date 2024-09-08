using Microsoft.AspNetCore.Mvc;
using SevenBridgeAMCProj.Models;
using System.Diagnostics;

namespace SevenBridgeAMCProj.Controllers
{
    public class HomeController : Controller
    {
        private SevenBridgeAMCContext context { get; set; }

        public HomeController(SevenBridgeAMCContext ctx) => context = ctx;

        public IActionResult Index()
        {
            var test = context.SevenBridges;
            var movies = context.SevenBridges.OrderBy(m => m.Name).ToList();
            return View(movies);
        }
        
    }
}