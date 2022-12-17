using System;

using Microsoft.AspNetCore.Components;
using BookStore.Models.Dtos; //(soln for error in ln 14)
using BookStore.Web.Services.Contracts;

namespace BookStore.Pages
{
	public class ProductBase:ComponentBase
	{

		[Inject]
	  public IBookService BookService { get; set; }

		public IEnumerable<BooksDto> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Products = await BookService.getItems();
             
        }
    }  
}

