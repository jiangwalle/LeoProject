using System;
using System.Collections.Generic;
using AutoMapper;

using RefactorMe.DontRefactor.Models;
using RefactorMe.DontRefactor.Data.Implementation;

namespace RefactorMe
{
	public class ProductService : IProductService
	{
		private ICurrencyService _currencyService;

		public ProductService(ICurrencyService currencyService)
		{
			this._currencyService = currencyService;
		}

		List<Product> IProductService.GetAll(List<object> repos, CurrencyType type)
		{
			List<Product> products = new List<Product>();

			foreach(var i in repos) {
				// Reflection to get repo details
				Type t = i.GetType();

				// Call repo.GetAll() to get specific product list. e.g.. PhoneCase

				// Foreach sepcific product list and convert to Product using AutoMapper

				// Convert price

				// Add converted Product to products list
			}

			return products;
		}
	}
}
