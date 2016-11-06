using System;
using System.Collections.Generic;
using RefactorMe.DontRefactor.Models;
using RefactorMe.service;

namespace RefactorMe
{
	public class ProductDataConsolidatorSolutionB
	{
		private IProductConsolidatorService _productConsolidatorService;

		public ProductDataConsolidatorSolutionB(IProductConsolidatorService productConsolidatorService)
		{
			this._productConsolidatorService = productConsolidatorService;
		}

		public List<Product> Get()
		{
			return this._productConsolidatorService.GetAllProduct(CurrencyType.NZ_DOLLOR);
		}

		public List<Product> GetInUSDollars()
		{
			return this._productConsolidatorService.GetAllProduct(CurrencyType.US_DOLLOR);
		}

		public List<Product> GetInEuros()
		{
			return this._productConsolidatorService.GetAllProduct(CurrencyType.EURO_DOLLOR);
		}
	}
}
