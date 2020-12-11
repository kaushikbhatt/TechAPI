using System;

using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TechnicalAssignment.Entities.Model;

namespace TechnicalAssignment.IRepository
{
    public interface ILibraryInquiry : IBase<Book>
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int Id);
        void CreateNewBook(Book book);
    }
}


