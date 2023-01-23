using ABCBooksClient_991471961.BookReference_991471961;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABCBooksClient_991471961.Controllers
{
    public class BookController : Controller
    {
        BookService_991471961Client client = new BookService_991471961Client();


        public ActionResult Landing()
        {
            return View();
        }



        public ActionResult Index()
        {
            return View(client.GetAllBooks().ToList());
        }




        public ActionResult Details(string author)
        {
            return View(client.GetABookByAuthor(author));
        }




        public ActionResult Create()
        {
            return View();
        }




        [HttpPost]
        public ActionResult Create(BookInfo book)
        {
            try
            {
                client.AddBook(book);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }




        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(string bookTitle)
        {
            try
            {
                BookInfo book = client.GetABookByTitle(bookTitle);

                client.EditBook(book);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }




        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(string isbn)
        {
            BookInfo book = client.GetABookByISBN(isbn);
            try
            {
                client.DeleteBook(book);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
