namespace BookApi.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
        public int CategoryId { get; set; }
    }
}
