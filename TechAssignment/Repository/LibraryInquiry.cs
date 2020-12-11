using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalAssignment.Entities;
using TechnicalAssignment.Entities.Model;
using TechnicalAssignment.IRepository;

namespace TechnicalAssignment.Repository
{
    public class LibraryInquiry : Base<Book>, ILibraryInquiry
    {

        public LibraryInquiry(RepositoryContext repositoryContext)
         : base(repositoryContext)
        {

        }


        public IEnumerable<Book> GetAllBooks()
        {
            return FindAll()
                .OrderBy(book => book.Author);
        }

        public Book GetBookById(int Id)
        {

            return (from a in RepositoryContext.Book
                    where a.Id == Id
                    select a).FirstOrDefault();
        }

        public void CreateNewBook(Book book)
        {

            Create(book);
            Save();
        }


    }
}
