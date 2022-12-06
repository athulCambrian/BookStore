using System;
using BookStore.Services.Contracts;
using Microsoft.AspNetCore.Components;
using BookStore.Models.Dtos; //(soln for error in ln 14)

namespace BookStore.Pages
{
	public class ProductBase:ComponentBase
	{

		[Inject]
	  public iProductService ProductService { get; set; }

		public IEnumerable<ProductDto> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();
             
        }
    }
}

