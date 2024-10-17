using Microsoft.AspNetCore.Mvc;
using Store_Project.Data;

namespace Store_Project.Models
{
    public class Navbar: ViewComponent
    {
        private readonly Store_ProjectContext _context;

        public Navbar(Store_ProjectContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Category.ToList());
        }

    }
}
