using System;

using Microsoft.AspNetCore.Components;
using BookStore.Models.Dtos; 
using BookStore.Web.Services.Contracts;

namespace BookStore.Pages
{ 
	public class ProductBase:ComponentBase
	{

		[Inject]
	  public IBookService BookService { get; set; }

		public IEnumerable<BooksDto> Productss { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Productss = await BookService.GetItems();
             
        }
    }  
}

