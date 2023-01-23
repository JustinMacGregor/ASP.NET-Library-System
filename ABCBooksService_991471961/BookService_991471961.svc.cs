using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ABCBooksService_991471961
{
    // IMPLEMENTS INTERFACE DECLARED IN IDBService.cs
    public class DBService : IBookService_991471961
    {
        ABCBookstoreDB_991471961Entities context = new ABCBookstoreDB_991471961Entities();

        public void AddBook(BookInfo book)
        {
            context.BookInfoes.Add(book);
            context.SaveChanges();
        }

        public void DeleteBook(BookInfo book)
        {
            context.BookInfoes.Remove(context.BookInfoes.Find(book.Id));
            context.SaveChanges();
        }

        public void EditBook(BookInfo book)
        {
            var b = context.BookInfoes.Where(boo => boo.Title == book.Title).FirstOrDefault();
            context.Entry(b).State = EntityState.Modified;
            context.SaveChanges();
        }

        public BookInfo GetABook(int id)
        {
            return context.BookInfoes.SingleOrDefault(b => b.Id == id);
        }

        public BookInfo GetABookByAuthor(string author)
        {
            return context.BookInfoes.SingleOrDefault(b => b.Author == author);
        }

        public BookInfo GetABookByISBN(string isbn)
        {
            return context.BookInfoes.SingleOrDefault(b => b.ISBN == isbn);
        }

        public BookInfo GetABookByTitle(string title)
        {
            var entry = context.BookInfoes.Where(b => b.Title == title).FirstOrDefault();
            return entry;
        }



        public List<BookInfo> GetAllBooks()
        {
            return context.BookInfoes.ToList();
        }
    }
}
