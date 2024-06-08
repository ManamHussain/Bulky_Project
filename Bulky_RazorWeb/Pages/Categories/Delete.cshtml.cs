using Bulky_RazorWeb.Data;
using Bulky_RazorWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bulky_RazorWeb.Pages.Categories
{
   
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Category Category { get; set; }
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int? id)
        {
            if (id != null && id != 0)
            {
               Category category = _db.Categories.Find(id);
            }
        }
        public IActionResult OnPost()
        {

            Category? obj = _db.Categories.Find(Category.CategoryId);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            return RedirectToPage("Index");

        }
    }
}
