using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Book
    {

        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Author { get; set; }
        public string? Category { get; set; }

        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }


    }
}
