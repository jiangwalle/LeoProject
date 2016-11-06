using System;
using System.Collections.Generic;

using RefactorMe.DontRefactor.Data.Implementation;
using RefactorMe.DontRefactor.Models;

namespace RefactorMe.service
{
	/// <summary>
	/// This interface is used to convert specific stuff like 'TShirt' to 'Product' list
	/// </summary>
	public interface IProductConvertService
	{
		/// <summary>
		/// Convert 
		/// </summary>
		/// <returns>The all.</returns>
		/// <param name="repos">Repos.</param>
		List<Product> convertToProductList(CurrencyType type);
	}
}