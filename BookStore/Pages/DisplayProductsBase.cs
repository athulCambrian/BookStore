//using System;
using Microsoft.AspNetCore.Components;
using BookStore.Models.Dtos; 

namespace BookStore.Pages
{
	public class DisplayProductsBase:ComponentBase 
	{
		[Parameter]
		public IEnumerable<ProductDto> Products { get; set; }
	} 
}

