using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.Dtos
{
    public class BooksDto
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string CategoryName { get; set; }
        public int Qty { get; set; }
        public int CategoryId { get; set; }
    }
}
