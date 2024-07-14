using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
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
            IEnumerable<Category> categoryList = _db.categories;
            return View(categoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("CError", "The Dis can not matvh the Name!");
            }
            if (ModelState.IsValid)
            {
                _db.categories.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Category created successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
                return NotFound();
            var categoryFromDb = _db.categories.Find(id);

            if (categoryFromDb == null)
                return NotFound();

            return View(categoryFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("CError", "The Dis can not matvh the Name!");
            }
            if (ModelState.IsValid)
            {
                _db.categories.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
                return NotFound();
            var categoryFromDb = _db.categories.Find(id);

            if (categoryFromDb == null)
                return NotFound();

            return View(categoryFromDb);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var categoryFromDb = _db.categories.Find(id);

            if (categoryFromDb == null)
                return NotFound();

            _db.categories.Remove(categoryFromDb);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}
