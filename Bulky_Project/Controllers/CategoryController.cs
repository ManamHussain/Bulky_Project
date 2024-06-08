using Bulky_Project.Data;
using Bulky_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

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

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public  async Task<IActionResult> Create(Categories Obj)
        {

            if (Obj.Name == "")
            {
                ModelState.AddModelError("name", "The Name must be String.");
           }
            if (Obj.Name == Obj.OrderDisplay.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
            }
            if (ModelState.IsValid)
            {
                _db.Categories.Add(Obj);
              await _db.SaveChangesAsync();
             TempData["success"] = "Category Created Successfully";
            return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null || id==0) 
            {
            return NotFound();
            }
            Categories? categoryfromDb1 = await _db.Categories.FindAsync(id);
           // Categories? categoryfromDb2 = await _db.Categories.FirstOrDefaultAsync(u => u.CategoryId == id);
           // Categories? categoryfromDb3 = await _db.Categories.Where(u => u.CategoryId == id).FirstOrDefaultAsync();
            if (categoryfromDb1==null) { return NotFound(); }
            return View(categoryfromDb1);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Categories Obj)
        {
            if (ModelState.IsValid)
            {
                    _db.Categories.Update(Obj);
                    await _db.SaveChangesAsync();
                TempData["success"] = "Category Updated Successfully";
                return RedirectToAction("Index");
               
            }
            return View();
        }

        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Categories? categoryfromDb1 = await _db.Categories.FindAsync(id);
            // Categories? categoryfromDb2 = await _db.Categories.FirstOrDefaultAsync(u => u.CategoryId == id);
            // Categories? categoryfromDb3 = await _db.Categories.Where(u => u.CategoryId == id).FirstOrDefaultAsync();
            if (categoryfromDb1 == null) { return NotFound(); }
            return View(categoryfromDb1);
        }
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            Categories? categories = await _db.Categories.FindAsync(id);
            if(categories == null) { return NotFound(); }

                _db.Categories.Remove(categories);
                await _db.SaveChangesAsync();
            TempData["success"] = "Category Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
  
}
