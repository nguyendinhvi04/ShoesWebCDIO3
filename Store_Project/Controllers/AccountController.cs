using Microsoft.AspNetCore.Mvc;
using Store_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Store_Project.Data;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
namespace Store_Project.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly Store_ProjectContext _context;

        public AccountController(Store_ProjectContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult RegisterCustomer()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterCustomer(ViewModels.RegisterCustomerViewModel model)
        {
            
           
            if (ModelState.IsValid)
            {
                
                var user = new User
                {
                    Name = model.NameUser,
                    Email = model.Email,
                    Password = model.Password 
                };

                if (user == null || _context.User == null)
                {
                    TempData["ErrorMessage"] = "Tên đăng nhập hoặc mật khẩu đã tổn tại";
                    return RedirectToAction("RegisterCustomer");

                }
                _context.Add(user);
                await _context.SaveChangesAsync();

               
                var customer = new Customer
                {
                    FullName = model.FullName,
                    Birthday = model.Birthday,
                    Address = model.Address,
                    Phone = model.Phone, 
                    UserId = user.Id
                };
                if (customer == null || _context.Customer == null)
                {
                    TempData["ErrorMessage"] = "Tên hoặc Thông Tin Khác Bị Sai";
                    return RedirectToAction("RegisterCustomer");

                }
                _context.Add(customer);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }
    }
}
