namespace BookApi.Entities
{
    public class BookCart
    {

        public int Id { get; set; }
        public int CartId { get; set; }
        public int BooksId { get; set; }
        public int Qty { get; set; }

    }
}
