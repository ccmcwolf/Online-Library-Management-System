namespace OnlineLibraryManagementSystem
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LibraryDB : DbContext
    {
        public LibraryDB()
            : base("name=LibraryDB")
        {
        }

        public virtual DbSet<Available_Items> Available_Items { get; set; }
        public virtual DbSet<Book_borrow> Book_borrow { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Return_books> Return_books { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .Property(e => e.book_name)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.author)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.publisher)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.p_year)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.edition)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.category)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.isbn_no)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.is_borrowed)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.nic)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.contact)
                .IsUnicode(false);

            modelBuilder.Entity<Return_books>()
                .Property(e => e.actual_return_date)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Supplier_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Supplier_Contact)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Supplier_Address)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.User_Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.User_Type)
                .IsUnicode(false);
        }
    }
}
