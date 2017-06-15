using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace OnlineLibraryManagementSystem.DAO
{
    public class  BookBorrowDAO
    {
        public Boolean addBook_borrow( Book_borrow item)
        {
            Boolean status = false;
            try
            {
                using (var db = new LibraryDB())
                {

                    db. Book_borrow.Add(item);
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

        public Boolean updateBook_borrow( Book_borrow item)
        {
            Boolean status = false;
            try
            {
                using (var db = new LibraryDB())
                {
                    Console.WriteLine("Book detail updated");
                    db. Book_borrow.AddOrUpdate(item);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update book problem " + ex.InnerException);
            }
            return status;
        }

        public List< Book_borrow> loadAllBook_borrows()
        {
            List< Book_borrow> books = null;

            try
            {
                using (var db = new LibraryDB())
                {

                    books = db.Set< Book_borrow>().ToList();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            return books;
        }

        public Book_borrow findByBook_borrowByID(int bookID)
        {
             Book_borrow  Book_borrow = null;
            try
            {
                using (var db = new LibraryDB())
                {

                     Book_borrow = db. Book_borrow.Find(bookID);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("find book by id " + ex.InnerException);
            }
            return Book_borrow;
        }
    }
}