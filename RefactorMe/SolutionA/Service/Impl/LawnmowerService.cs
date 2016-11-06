using System;
using System.Collections.Generic;
using AutoMapper;
using RefactorMe.DontRefactor.Models;
using RefactorMe.DontRefactor.Data.Implementation;

namespace RefactorMe.service
{
	public class LawnmowerService : ILawnmowerService, IProductConvertService
	{
		private ICurrencyService _currencyService;
		private BaseReadOnlyRepository<Lawnmower> _repository;
		private IMapper _mapper;

		public LawnmowerService(ICurrencyService currencyService,
		                        BaseReadOnlyRepository<Lawnmower> repository,
		                        IMapper mapper)
		{
			this._currencyService = currencyService;
			this._repository = repository;
			this._mapper = mapper;
		}

		public List<Product> convertToProductList(CurrencyType type)
		{
			List<Product> productList = new List<Product>();

			var l = this._repository.GetAll();
			foreach (var i in l)
			{
				var product = this._mapper.Map<Lawnmower, Product>(i);
				product.Price = product.Price * this._currencyService.GetCurrency(type).Rate;
				productList.Add(product);
			}

			return productList;
		}

		public void LawnmowerRelatedStuff()
		{
			throw new NotImplementedException();
		}
	}
}
