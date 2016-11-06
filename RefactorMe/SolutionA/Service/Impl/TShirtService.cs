using System;
using System.Collections.Generic;
using AutoMapper;
using RefactorMe.DontRefactor.Models;
using RefactorMe.DontRefactor.Data.Implementation;

namespace RefactorMe.service
{
	public class TShirtService : ITShirtService, IProductConvertService
	{
		private ICurrencyService _currencyService;
		private BaseReadOnlyRepository<TShirt> _repository;
		private IMapper _mapper;

		public TShirtService(ICurrencyService currencyService,
								BaseReadOnlyRepository<TShirt> repository,
								IMapper mapper)
		{
			this._repository = repository;
			this._mapper = mapper;
			this._currencyService = currencyService;
		}

		public List<Product> convertToProductList(CurrencyType type)
		{
			List<Product> productList = new List<Product>();

			var l = this._repository.GetAll();
			foreach (var i in l)
			{
				var product = this._mapper.Map<TShirt, Product>(i);
				product.Price = product.Price * this._currencyService.GetCurrency(type).Rate;
				productList.Add(product);
			}

			return productList;
		}

		public void DoTShirtRelatedStuff()
		{
			throw new NotImplementedException();
		}
	}
}
