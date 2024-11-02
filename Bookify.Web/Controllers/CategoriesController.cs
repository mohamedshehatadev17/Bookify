
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
			var categories = _context.Categories.AsNoTracking().ToList();
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
			var category = _context.Categories.Find(id);
			if (category is null)
				return NotFound();
			var FormViewModel = new CategoryFormViewModel
			{
				Id = id,
				Name = category.Name,
			};

			return View("Form",FormViewModel);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(CategoryFormViewModel model)
		{
			if (!ModelState.IsValid)
				return View("Form", model);
			var category = _context.Categories.Find(model.Id);
			if(category is null)
				return NotFound();
			category.Id= model.Id;
			category.Name = model.Name;
			category.LastUpdatedOn = DateTime.Now;
			_context.SaveChanges();
			return RedirectToAction(nameof(Index));
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult ToggleStatus(int id)
		{
			var category = _context.Categories.Find(id);
			if(category is null)
				return NotFound();
			category.IsDeleted = !category.IsDeleted;
			category.LastUpdatedOn= DateTime.Now;
			_context.SaveChanges();
			return Ok(); // add view 
		}
	}
}
