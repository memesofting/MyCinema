using MyCinemaWeb.Data;
using Microsoft.AspNetCore.Mvc;
using MyCinemaWeb.Models;

namespace MyCinemaWeb.Controllers
{
	public class MovieController : Controller
	{
		private readonly ApplicationDbContext _db;

		public MovieController(ApplicationDbContext db)
		{
			_db = db;
		}
		public IActionResult Index()
		{
			IEnumerable<Movie> objMovieList = _db.Movies;
			return View(objMovieList);
		}
	}
}
