using Microsoft.AspNetCore.Mvc;
using CetStudentBook.Data;
using CetStudentBook.Models;
using System.Linq;

namespace CetStudentBook.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // LIST
        public IActionResult Index()
        {
            var books = _context.Books.ToList();
            return View(books);
        }

        // CREATE GET
        public IActionResult Create()
        {
            return View();
        }

        // CREATE POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Books.Add(book);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(book);
        }

        // EDIT GET
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var book = _context.Books.Find(id);

            if (book == null)
                return NotFound();

            return View(book);
        }

        // EDIT POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Book book)
        {
            if (id != book.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(book);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(book);
        }

        // DELETE GET
        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var book = _context.Books.Find(id);

            if (book == null)
                return NotFound();

            return View(book);
        }

        // DELETE POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = _context.Books.Find(id);

            if (book == null)
                return NotFound();

            _context.Books.Remove(book);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}