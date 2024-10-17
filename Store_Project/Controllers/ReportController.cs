using Microsoft.AspNetCore.Mvc;

namespace Store_Project.Controllers
{
	public class ReportController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public ActionResult GenerateReport(decimal Performance, string CustomerFeedback, decimal Revenue, decimal Expenses)
		{
			
			ViewBag.Performance = Performance;
			ViewBag.CustomerFeedback = CustomerFeedback;
			ViewBag.Revenue = Revenue;
			ViewBag.Expenses = Expenses;

			return View("ReportResult");
		}
	}
}
