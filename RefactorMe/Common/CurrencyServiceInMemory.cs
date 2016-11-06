using System;
using System.Collections.Generic;

using RefactorMe.Exception;

namespace RefactorMe.service
{
	public class CurrencyServiceInMemory : ICurrencyService
	{
		private static Dictionary<CurrencyType, Currency> Currencies = new Dictionary<CurrencyType, Currency>();

		public CurrencyServiceInMemory()
		{
			Currencies.Add(CurrencyType.NZ_DOLLOR, new Currency(CurrencyType.NZ_DOLLOR, 1.00f));
			Currencies.Add(CurrencyType.US_DOLLOR, new Currency(CurrencyType.US_DOLLOR, 0.76f));
			Currencies.Add(CurrencyType.EURO_DOLLOR, new Currency(CurrencyType.EURO_DOLLOR, 0.67f));
		}

		public void AddCurrency(Currency currency)
		{
			Currencies.Add(currency.Type, currency);
		}

		public List<Currency> GetCurrencyList()
		{
			List<Currency> res = new List<Currency>();
			res.AddRange(Currencies.Values);

			return res;
		}

		public Currency GetCurrency(CurrencyType type)
		{
			if (Currencies.ContainsKey(type))
			{
				return Currencies[type];
			}
			else 
			{
				throw new UnknownCurrencyException("Unknow currency type: " + type.ToString());
			}
		}

		public void RemoveCurrency(CurrencyType type)
		{
			if (Currencies.ContainsKey(type))
			{
				Currencies.Remove(type);
			}
			else
			{
				throw new UnknownCurrencyException("Unknow currency type: " + type.ToString());
			}
		}
	}
}
