using Microsoft.EntityFrameworkCore;
using PaginationApp.Data.Models;

namespace PaginationApp.Data
{
    public class BookDbContext:DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext>options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
           new Book { Id = 1, Title = "The Bible", Author= "Several authors", Genre="Religious" },
           new Book { Id = 2, Title = "Quotations from Chairman Mao Tse-Tung", Author = "Mao Zedong", Genre = "Political" },
           new Book { Id = 3, Title = "The Quran", Author = "Several authors", Genre = "Religious" },
           new Book { Id = 4, Title = "The Lord Of The Rings", Author = "John Tolkien", Genre = "Fantasy" },
           new Book { Id = 5, Title = "The Little Prince", Author = "Antoine de Saint-Exupery", Genre = "Children’s Novel" },
           new Book { Id = 6, Title = "Harry Potter and the Philosopher’s Stone", Author = "Joanne Rowling", Genre = "Fantasy" },
           new Book { Id = 7, Title = "Scouting for Boys", Author = "Robert Baden-Powell", Genre = "Manual / Instructional" },
           new Book { Id = 8, Title = "And Then There Were None", Author = "Agatha Christie", Genre = "Mystery Crime" },
           new Book { Id = 9, Title = "The Hobbit", Author = "John Tolkien", Genre = "Fantasy" },
           new Book { Id = 10, Title = "The Dream Of The Red Chamber", Author = "Cao Xueqin", Genre = "Novel" }
           );
        }
        public DbSet<Book>Books { get; set;}
    }
}
