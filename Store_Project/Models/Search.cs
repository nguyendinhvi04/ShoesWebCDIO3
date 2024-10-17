using Microsoft.AspNetCore.Mvc;
using Store_Project.Data;

namespace Store_Project.Models
{
    public class Search : ViewComponent
    {
        private readonly Store_ProjectContext _context;

        public Search(Store_ProjectContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Category.ToList());
        }
    }
}
