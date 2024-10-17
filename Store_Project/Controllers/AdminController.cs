using Microsoft.AspNetCore.Mvc;

namespace Store_Project.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
