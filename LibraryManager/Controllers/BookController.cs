using LibraryManager.Data;
using LibraryManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.Controllers
{
    public class BookController : Controller
    {
        private readonly LibraryManagerContext _dbContext;
        public BookController(LibraryManagerContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var data = _dbContext.Books.ToList();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Book model)
        {
            if (ModelState.IsValid)
            {
                await _dbContext.Books.AddAsync(model);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction("Index", "Book");
            }
            return View();
        }
        public async Task<IActionResult> Edit(string id)
        {
            var data = await _dbContext.Books.FindAsync(id);
            if (data == null) NotFound();
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Book model)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Books.Update(model);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction("Index", "Book");
            }
            return View(model);
        }

        public async Task<IActionResult> Details(string id)
        {
            var data = await _dbContext.Books.FirstOrDefaultAsync(x => x.Id == id);
            return View(data);
        }

        public async Task<IActionResult> Delete(string id)
        {
            var data = await _dbContext.Books.FindAsync(id);
            if (data == null) NotFound();
            return View(data);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(string id)
        {
            var data = await _dbContext.Books.FindAsync(id);
            if (data == null) NotFound();
            _dbContext.Books.Remove(data);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
