﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace OnlineLibraryManagementSystem.DAO
{
    public class Available_ItemsDAO
    {
        public Boolean addAvailableItem(Available_Items item)
        {
            Boolean status = false;
            try
            {
                using (var db = new LibraryDB())
                {

                    db.Available_Items.Add(item);
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

        public Boolean updateItem(Available_Items item)
        {
            Boolean status = false;
            try
            {
                using (var db = new LibraryDB())
                {
                    Console.WriteLine("Book detail updated");
                    db.Available_Items.AddOrUpdate(item);
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

        public List<Available_Items> loadAllAvailableItems()
        {
            List<Available_Items> books = null;

            try
            {
                using (var db = new LibraryDB())
                {

                    books = db.Set<Available_Items>().ToList();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            return books;
        }

        public Available_Items findByAvailable_ItemsByID(int bookID)
        {
            Available_Items availableItem = null;
            try
            {
                using (var db = new LibraryDB())
                {

                    availableItem = db.Available_Items.Find(bookID);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("find book by id " + ex.InnerException);
            }
            return availableItem;
        }


    }
}