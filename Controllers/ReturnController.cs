using Library.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class ReturnController : Controller
    {
        private LibraryContext db = new LibraryContext();

        // GET: Return
        public ActionResult Index()
        {
            ViewBag.clients = db.Books.ToList();
            ViewBag.clients = db.Clients.ToList();
            return View(db.Borrows.Where(b => b.returnDate == null).ToList());
        }

        public ActionResult Return([Bind(Include = "Id, bookId")] Borrow borrow)
        {
            if (ModelState.IsValid)
            {
                Book book = db.Books.Find(borrow.bookId);
                book.copy++;
                db.Entry(book).State = EntityState.Modified;

                borrow = db.Borrows.Find(borrow.Id);
                borrow.returnDate = DateTime.Now;
                db.Entry(borrow).State = EntityState.Modified;

                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(borrow);
        }
    }
}