using DAL.Entity;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(LibraryDbContext libraryDbContext) : base(libraryDbContext)
        {
        }
    }
}
