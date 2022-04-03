using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.DataContext
{
    public class LibraryContext : DbContext
    {
        public LibraryContext()
        {

        }
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("LibraryDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> User { get; set; }
        public DbSet<Book> Books{ get; set; }
        public DbSet<Student> Students{ get; set; }
        public DbSet<Librarian> Librarians{ get; set; }
        public DbSet<Transaction> Transactions{ get; set; }
        public DbSet<Borrowing> Borrowings{ get; set; }

    }
}
