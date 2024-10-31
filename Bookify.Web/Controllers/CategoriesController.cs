using Microsoft.AspNetCore.Mvc;

namespace Bookify.Web.Controllers
{
	public class CategoriesController : Controller
	{
		private readonly ApplicationDbContext _context;

		public CategoriesController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			// TODO : USE VIEWmODEL
			var categories = _context.Categories.ToList();
			return View(categories);
		}
		public IActionResult Create()
		{
			return View();
		}
	}
}
