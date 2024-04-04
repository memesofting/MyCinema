using Microsoft.AspNetCore.Mvc;

namespace MyCinemaWeb.Controllers
{
	public class MovieController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
