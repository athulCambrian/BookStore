using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.Dtos
{
    public class CartItemDto
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int CartId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
    }
}
