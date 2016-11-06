using System;
using System.Collections.Generic;

using RefactorMe.DontRefactor.Models;

namespace RefactorMe.service
{
	public interface IProductConsolidatorService
	{
		/// <summary>
		/// This method will automaticlly find all products repositories in Assembly 'RefactorMe.DontRefactor'
		/// and convert each specific Type to Product.
		/// 
		/// Note: All the repository under RefactorMe.DontRefactor should follow default naming pattern.
		/// Which should be ends with 'Repository'. e.g. LawnmowerRepository.
		/// </summary>
		/// <returns>The all product.</returns>
		/// <param name="type">Type.</param>
		List<Product> GetAllProduct(CurrencyType type);
	}
}
