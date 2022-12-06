using System;
using System.Net.Http.Json;
using BookStore.Services.Contracts;

namespace BookStore.Services
{
	public class ProductService : iProductService 
	{
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
		{
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductDto>> GetItems()
        {
            try
            {
                var products = await this.httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/Product");
                return products; 
            }

            catch (Exception)

            {
                 

            }
        }
    }
}

