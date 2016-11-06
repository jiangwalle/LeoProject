using System;
using System.Collections.Generic;

using RefactorMe.service;
using RefactorMe.DontRefactor.Models;

namespace RefactorMe
{
	public class ProductDataConsolidatorSolutionA
	{
		private LawnmowerService _lawnmowerService;
		private PhoneCaseService _phoneCaseService;
		private TShirtService _tShirtService;

		public ProductDataConsolidatorSolutionA(LawnmowerService lawnmowerService,
		                                        PhoneCaseService phoneCaseService,
		                                        TShirtService tShirtService)
		{
			this._lawnmowerService = lawnmowerService;
			this._phoneCaseService = phoneCaseService;
			this._tShirtService = tShirtService;
		}

		public List<Product> Get()
		{
			List<Product> productList = new List<Product>();
			productList.AddRange(this._lawnmowerService.convertToProductList(CurrencyType.NZ_DOLLOR));
			productList.AddRange(this._phoneCaseService.convertToProductList(CurrencyType.NZ_DOLLOR));
			productList.AddRange(this._tShirtService.convertToProductList(CurrencyType.NZ_DOLLOR));
			return productList;
		}

		public List<Product> GetInUSDollars()
		{
			List<Product> productList = new List<Product>();
			productList.AddRange(this._lawnmowerService.convertToProductList(CurrencyType.US_DOLLOR));
			productList.AddRange(this._phoneCaseService.convertToProductList(CurrencyType.US_DOLLOR));
			productList.AddRange(this._tShirtService.convertToProductList(CurrencyType.US_DOLLOR));
			return productList;
		}

		public List<Product> GetInEuros()
		{
			List<Product> productList = new List<Product>();
			productList.AddRange(this._lawnmowerService.convertToProductList(CurrencyType.EURO_DOLLOR));
			productList.AddRange(this._phoneCaseService.convertToProductList(CurrencyType.EURO_DOLLOR));
			productList.AddRange(this._tShirtService.convertToProductList(CurrencyType.EURO_DOLLOR));
			return productList;
		}
	}
}
