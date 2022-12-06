using System;

// using BookStore.Models.Dtos;

namespace BookStore.Services.Contracts
{
	public interface iProductService
	{
		Task<IEnumerable<ProductDto>> GetItems();
	}
}

