using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace OnlineLibraryManagementSystem.DAO
{
    public class ReturnBooks
    {
        public Boolean addReturnBook(Return_books returnBooks)
        {
            Boolean status = false;
            try
            {
                using (var db = new LibraryDB())
                {

                    db.Return_books.Add(returnBooks);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            return status;
        }

        public Boolean updateReturnBook_borrow(Return_books returnBook)
        {
            Boolean status = false;
            try
            {
                using (var db = new LibraryDB())
                {
                    Console.WriteLine("Returnbook detail updated");
                    db.Return_books.AddOrUpdate(returnBook);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update returnBook problem " + ex.InnerException);
            }
            return status;
        }

        public List<Return_books> loadAllReturnBook()
        {
            List<Return_books> books = null;

            try
            {
                using (var db = new LibraryDB())
                {

                    books = db.Set<Return_books>().ToList();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            return books;
        }

        public Return_books findByBook_borrowByID(int bookID)
        {
            Return_books returnBooks = null;
            try
            {
                using (var db = new LibraryDB())
                {

                    returnBooks = db.Return_books.Find(bookID);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("find returnBooks by id " + ex.InnerException);
            }
            return returnBooks;
        }
    }
}