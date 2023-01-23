using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ABCBooksService_991471961
{
    [ServiceContract]
    public interface IBookService_991471961
    {
        [OperationContract]
        List<BookInfo> GetAllBooks();



        [OperationContract] 
        BookInfo GetABook(int id);


        [OperationContract]
        BookInfo GetABookByISBN(string isbn);


        [OperationContract]
        BookInfo GetABookByTitle(string title);


        [OperationContract]
        BookInfo GetABookByAuthor(string author);



        [OperationContract]
        void EditBook(BookInfo book);



        [OperationContract]
        void AddBook(BookInfo book);



        [OperationContract]
        void DeleteBook(BookInfo book);
    }
}
