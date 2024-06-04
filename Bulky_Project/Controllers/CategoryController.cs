using Bulky_Project.Data;
using Bulky_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bulky_Project.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
                _db = db;
        }
        public IActionResult Index()
        {
           List<Categories> categories = _db.Categories.ToList();
            return View(categories);
        }
    }
}
