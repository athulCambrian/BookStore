using System;
using Microsoft.AspNetCore.Components;

namespace BookStore.Web.Pages
{
	public class ProductDetailsBase
	{
		[Parameter]
		public int id { get; set; }

		public IProductService ProductService { get; set; }

		public BooksDto BookDetails { get; set; }

        public string ErrorMessage { get; set; }


        protected override async Task OnInitializedAsync()
        {
            try
            {
                ShoppingCartItems = await ManageCartItemsLocalStorageService.GetCollection();
                Product = await GetProductById(Id);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}

