using System;
using System.Collections.Generic;

using AutoMapper;
using RefactorMe.DontRefactor.Data.Implementation;
using RefactorMe.DontRefactor.Models;

namespace RefactorMe
{
	public class LawnmowerService : IProductService
	{
		private BaseReadOnlyRepository<Lawnmower> _rep;
		private ICurrencyService _currencyService;

		public LawnmowerService(BaseReadOnlyRepository<Lawnmower> rep,
		                        ICurrencyService currencyService)
		{
			this._rep = rep;
			this._currencyService = currencyService;
		}

		public List<Product> GetAll(CurrencyType type)
		{
			var ps = new List<Product>();

			var l = this._rep.GetAll();

			foreach (var i in l)
			{
				var product = Mapper.Map<Lawnmower, Product>(i);
				product.Price = this._currencyService.GetCurrency(type).Rate * product.Price;

				ps.Add(product);
			}

			return ps;
		}
	}
}
