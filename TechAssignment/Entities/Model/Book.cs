using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalAssignment.Entities.Model
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }

        public string Summary { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public string URL { get; set; }



    }
}
