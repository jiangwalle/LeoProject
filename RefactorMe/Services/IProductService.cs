using System;
using System.Collections.Generic;

using RefactorMe.DontRefactor.Data.Implementation;
using RefactorMe.DontRefactor.Models;

namespace RefactorMe
{
	public interface IProductService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <returns>The all.</returns>
		/// <param name="repos">Repos.</param>
		List<Product> GetAll(List<object> repos, CurrencyType type);
	}
}