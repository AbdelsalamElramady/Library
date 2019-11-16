using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class HistoryController : Controller
    {
        private LibraryContext db = new LibraryContext();

        // GET: History
        public ActionResult Index()
        {
            ViewBag.clients = db.Books.ToList();
            ViewBag.clients = db.Clients.ToList();
            return View(db.Borrows.Where(b => b.returnDate != null).ToList());
        }
    }
}