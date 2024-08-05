using Bulky_RazorWeb.Data;
using Bulky_RazorWeb.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bulky_RazorWeb.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
       public List<Category> CategoriesList {  get; set; }
        public IndexModel(ApplicationDbContext db)
        {
                _db = db;
        }
        public void OnGet()
        {
            CategoriesList = _db.Categories.ToList();
        }
    }
}
