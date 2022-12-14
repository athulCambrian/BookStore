using BookStore.Models.Dtos;
using BookStore.Web.Services.Contracts;
using System.Net.Http.Json;

namespace BookStore.Web.Services
{
    public class BooksService:IBookService

    {
        private readonly HttpClient httpClient;
        public BooksService(HttpClient httpClient)
        {
            this.httpClient=httpClient;
        }

        public async Task<IEnumerable<BooksDto>> GetItems()
        {
            try {
                var books = await this.httpClient.GetFromJsonAsync<IEnumerable<BooksDto>>("api/Books");
                return books;
                    
            }catch(Exception ex) {
                throw;
            }
        }
    }
}
