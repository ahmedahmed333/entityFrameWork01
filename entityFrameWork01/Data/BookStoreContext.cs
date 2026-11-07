using entityFrameWork01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace entityFrameWork01.Data
{
    internal class BookStoreContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseSqlServer(
                "Server=.;Database=ReadMoreBooksDb;Trusted_Connection=True;TrustServerCertificate=True"
                );
        }
        
        public DbSet<Book> Books => Set<Book>();
        public DbSet<Author> Authors => Set<Author>();

        public DbSet<Category> Categories => Set<Category>();




    }
}
