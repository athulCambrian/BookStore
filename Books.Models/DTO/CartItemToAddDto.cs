using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.Dtos
{
    public class CartItemToAddDto
    {

        public int CartId { get; set; }
        public int BookId { get; set; }
        public int Qty { get; set; }
    }
}
