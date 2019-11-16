using Library.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class BorrowController : Controller
    {
        private LibraryContext db = new LibraryContext();

        // GET: Borrow
        public ActionResult Index()
        {
            return View(db.Clients.ToList());
        }

        // GET: Books
        public ActionResult GetBooks(int clientId)
        {
            ViewBag.clientId = clientId;
            return View(db.Books.Where(book => book.copy > 0).ToList());
        }

        public ActionResult BorrowBook([Bind(Include = "clientId, bookId")] Borrow borrow)
        {
            if (ModelState.IsValid)
            {
                borrow.borrowDate = DateTime.Now;
                borrow.returnDate = null;
                db.Borrows.Add(borrow);

                Book book = db.Books.Find(borrow.bookId);
                if (book == null)
                {
                    return HttpNotFound();
                }
                book.copy--;
                db.Entry(book).State = EntityState.Modified;

                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(borrow);
        }
    }
}