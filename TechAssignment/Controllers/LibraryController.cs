using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechnicalAssignment.IRepository;
using TechnicalAssignment.Entities.Model;
namespace TechnicalAssignment.Controllers
{

    [Route("library")]
    [EnableCors("CorsPolicy")]

    public class LibraryController : ControllerBase
    {
        private ILibraryInquiry _repository;

        public LibraryController(ILibraryInquiry repository)
        {
           
            _repository = repository;
        }
      
        [HttpGet("getAll")]
        public IEnumerable<Book> getAll ()
        {
           return _repository.GetAllBooks();
          
        }

        [HttpGet("{id}")]
        public Book getBookById(int id)
        {
            return _repository.GetBookById(id);

        }

        [HttpPost]
        public void Create([FromBody] Book book)
        {
             _repository.CreateNewBook(book);

        }


    }


}