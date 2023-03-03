using Microsoft.EntityFrameworkCore;
using PaginationApp.Data;
using PaginationApp.Data.Models;

namespace PaginationApp.Repositories
{
    public class BookRepository:IBookRepository
    {
        private readonly BookDbContext _bookDbContext;
        const int ITEMPERPAGE= 3;

        public BookRepository(BookDbContext bookDbContext)
        {
            _bookDbContext = bookDbContext;
        }
        public async Task<List<Book>> GetBooks(int page)
        {
            return await _bookDbContext.Books.Skip((page - 1) * ITEMPERPAGE).Take(ITEMPERPAGE).ToListAsync();
        }
    }
}
