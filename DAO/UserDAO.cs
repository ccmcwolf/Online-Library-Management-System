using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace OnlineLibraryManagementSystem.DAO
{
    public class UserDAO
    {
        public Boolean addUser(User user)
        {
            Boolean status = false;
            try
            {
                using (var db = new LibraryDB())
                {

                    db.Users.Add(user);
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

        public Boolean updateUsers(User user)
        {
            Boolean status = false;
            try
            {
                using (var db = new LibraryDB())
                {
                    Console.WriteLine("User detail updated");
                    db.Users.AddOrUpdate(user);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update user problem " + ex.InnerException);
            }
            return status;
        }

        public List<User> loadAllUsers()
        {
            List<User> books = null;

            try
            {
                using (var db = new LibraryDB())
                {

                    books = db.Set<User>().ToList();

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
                Console.WriteLine("find user by id " + ex.InnerException);
            }
            return returnBooks;
        }
    }
}