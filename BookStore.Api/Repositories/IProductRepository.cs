using BookApi.Entities;

namespace BookApi.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Book>> GetBooks();
        Task<IEnumerable<Category>> GetCategories();
        Task<Book> GetItem(int id);
        Task<Category> GetCategory(int id);
    }
}
