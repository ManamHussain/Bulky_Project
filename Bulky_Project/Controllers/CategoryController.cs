using Bulky_Project.Data;
using Bulky_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bulky_Project.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
                _db = db;
        }
        public async Task<IActionResult> Index()
        {
           List<Categories> categories = await _db.Categories.ToListAsync();
            return View(categories);
        }
    }
}
