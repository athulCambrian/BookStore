using BookStore.Models.Dtos;

namespace BookStore.Web.Services.Contracts
{
    public interface IBookService
    {
        Task<IEnumerable<BooksDto>> GetItems();
    }
}
