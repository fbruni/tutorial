using AutoMapper;
using BLL.Models;
using BLL.Services.Interfaces;
using DAL.Entity;
using DAL.Repositories.Interfaces;

namespace BLL
{
    public class BookService : IBookService
    {
        private readonly IMapper mapper;
        private readonly IBookRepository bookRepository;

        public BookService(IMapper mapper, IBookRepository bookRepository)
        {
            this.mapper = mapper;
            this.bookRepository = bookRepository;
        }

        public void Delete(int id)
        {
            bookRepository.Delete(id);
            bookRepository.Save();
        }

        public IEnumerable<BookModel> GetBooks()
        {
            return mapper.Map<IEnumerable<BookModel>>(bookRepository.GetAll());
        }

        public BookModel? GetById(int id)
        {
            return mapper.Map<BookModel>(bookRepository.GetById(id));
        }

        public void Insert(BookModel book)
        {
            bookRepository.Insert(mapper.Map<Book>(book));
            bookRepository.Save();
        }

        public void Update(BookModel book)
        {
            bookRepository.Update(mapper.Map<Book>(book));
            bookRepository.Save();
        }
    }
}
