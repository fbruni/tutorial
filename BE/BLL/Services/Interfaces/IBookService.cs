using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IBookService
    {
        IEnumerable<BookModel> GetBooks();
        BookModel? GetById(int id);
        void Insert(BookModel book);
        void Update(BookModel book);
        void Delete(int id);
    }
}
