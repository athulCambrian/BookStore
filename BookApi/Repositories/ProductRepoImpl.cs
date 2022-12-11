using BookApi.Data;
using BookApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookApi.Repositories
{
    public class ProductRepoImpl : IProductRepository
    {
        private readonly ShopDbContext shopDbContext;

        public ProductRepoImpl(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }

       

        public async Task<IEnumerable<Book>> GetBooks()
        {
            var books = await shopDbContext.Books.ToListAsync();
            return books;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            var categories = await shopDbContext.Categorys.ToListAsync();
            return categories;
        }

        public Task<Category> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetItem(int id)
        {
            throw new NotImplementedException();
        }
    }
}
