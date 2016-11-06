using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using AutoMapper;
using RefactorMe.DontRefactor.Models;

namespace RefactorMe.service
{
	public class ProductConsolidatorService : IProductConsolidatorService
	{
		private ICurrencyService _currencyService;
		private IMapper _mapper;

		public ProductConsolidatorService(ICurrencyService currencyService,
		                                  IMapper iMapper)
		{
			this._currencyService = currencyService;
			this._mapper = iMapper;
		}

		public List<Product> GetAllProduct(CurrencyType currencyType)
		{
			List<Product> productList = new List<Product>();
			foreach (var repo in ReflectionHelper.GetAllRepos())
			{
				productList.AddRange(convertToProduct(repo, currencyType));
			}

			return productList;
		}

		private List<Product> convertToProduct(Type repoType, CurrencyType currencyType)
		{
			List<Product> productList = new List<Product>();

			MethodInfo method = repoType.GetMethod("GetAll");
			IQueryable list = method.Invoke(Activator.CreateInstance(repoType), null) as IQueryable;
			foreach (var l in list)
			{
				Product product = this._mapper.Map(l, l.GetType(), typeof(Product)) as Product;
				product.Price = product.Price * this._currencyService.GetCurrency(currencyType).Rate;
				productList.Add((Product)product);
			}

			return productList;
		}
	}
}
