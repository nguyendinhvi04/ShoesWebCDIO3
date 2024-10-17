using Microsoft.AspNetCore.Mvc;
using Store_Project.Models;

namespace Store_Project.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // GET: Order/PlaceOrder
        public ActionResult PlaceOrder()
        {
            // Mocking products, you can fetch products from a database or any other source
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Sản Phẩm 1", Description = "Mô tả", Price = 100000 },
                new Product { Id = 2, Name = "Sản Phẩm 2", Description = "Mô Tả", Price = 150000 },
                new Product { Id = 3, Name = "Sản Phẩm 3", Description = "Mô tả", Price = 200000}
            };

            var order = new OrderModel
            {
                OrderId = 1,
                OrderDate = DateTime.Now,
                CustomerName = "Nguyễn Đinh Vĩ",
                Products = products
            };

            return View(order);
        }

        // POST: Order/PlaceOrder
        [HttpPost]
        public ActionResult PlaceOrder(OrderModel model)
        {
            // Logic to process the order
            // You can save it to the database or any other operation

            // Redirect to a success page or show a success message
            return RedirectToAction("OrderSuccess");
        }

        public ActionResult OrderSuccess()
        {
            return View();
        }
    }
}
