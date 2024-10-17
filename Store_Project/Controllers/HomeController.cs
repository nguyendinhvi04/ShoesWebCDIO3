using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Store_Project.Data;
using Store_Project.Models;
using System.Diagnostics;

namespace Store_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly Store_ProjectContext _context;

        public HomeController(Store_ProjectContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Product?.Include(p => p.Category).ToList());
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
