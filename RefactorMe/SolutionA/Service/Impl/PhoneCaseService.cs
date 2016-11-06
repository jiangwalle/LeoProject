using System;
using System.Collections.Generic;
using AutoMapper;
using RefactorMe.DontRefactor.Models;
using RefactorMe.DontRefactor.Data.Implementation;

namespace RefactorMe.service
{
	public class PhoneCaseService : IPhoneCaseService, IProductConvertService
	{
		private ICurrencyService _currencyService;
		private BaseReadOnlyRepository<PhoneCase> _repository;
		private IMapper _mapper;

		public PhoneCaseService(ICurrencyService currencyService,
								BaseReadOnlyRepository<PhoneCase> repository,
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
				var product = this._mapper.Map<PhoneCase, Product>(i);
				product.Price = product.Price * this._currencyService.GetCurrency(type).Rate;
				productList.Add(product);
			}

			return productList;
		}

		public void DoPhoneCaseRelatedStuff()
		{
			throw new NotImplementedException();
		}
	}
}
