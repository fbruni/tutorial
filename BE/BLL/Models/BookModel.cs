using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public required string? Title { get; set; }

        public required string? Description { get; set; }

        public required string? Author { get; set; }

        public required string? Category { get; set; }

        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
