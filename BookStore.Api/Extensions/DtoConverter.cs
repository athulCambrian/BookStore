using BookApi.Entities;
using BookStore.Models.Dtos;

namespace BookApi.Converters
{
    public static class DtoConverter
    {
        public static IEnumerable<BooksDto> ConvertToDto(this IEnumerable<Book> books, IEnumerable<Category> categorys) {
            return (
    from book in books
    join category in categorys
    on book.CategoryId equals category.Id
    select new BooksDto { 
    Id=book.Id,
    BookName=book.Name,
    Description=book.Description,
    Author=book.Author,
    CategoryName=category.Name,
    Qty=book.Qty,
    CategoryId=book.CategoryId,
    
    }
                    ).ToList();
        }
    }
}
