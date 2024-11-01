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
			return View("Form");
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(CategoryFormViewModel model)
		{
			if(!ModelState.IsValid)
			{
				return View("Form",model);
			}
			var category = new Category { Name = model.Name };
			_context.Categories.Add(category);
			_context.SaveChanges();

			return RedirectToAction(nameof(Index));
		}
		[HttpGet]
		public IActionResult Edit(int id)
		{
			return View("Form");
		}
	}
}
