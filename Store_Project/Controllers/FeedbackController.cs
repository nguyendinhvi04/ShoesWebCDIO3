using Microsoft.AspNetCore.Mvc;

namespace Store_Project.Controllers
{
    public class FeedbackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubmitFeedback(string Name, string Email, string Message)
        {
            // Logic to process the feedback
            // You can save it to the database or any other operation

            // For demonstration purpose, let's just display the feedback on a Thank You page
            ViewBag.Name = Name;
            ViewBag.Email = Email;
            ViewBag.Message = Message;

            return View("Cảm Ơn");
        }
    }
}
