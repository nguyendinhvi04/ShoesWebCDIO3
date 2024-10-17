using Microsoft.AspNetCore.Mvc;

namespace Store_Project.Models.ViewComponents
{
	public class NavbarAdminViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			// Logic để lấy dữ liệu cho view component, nếu cần
			return View();
		}
	}
}
