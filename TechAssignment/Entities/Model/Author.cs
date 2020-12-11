using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalAssignment.Entities.Model
{
    [Table("Author")]
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string first_name { get; set; }
         public string family_name { get; set; }
        public DateTime date_of_birth { get; set; }
        public string name { get; set; }
        public string lifespan { get; set; }
        public string url { get; set; }
    }
}
