using PaginationApp.Data.Models;

namespace PaginationApp.Repositories
{
    public interface IBookRepository
    {
        public Task<List<Book>> GetBooks(int page);
    }
}
