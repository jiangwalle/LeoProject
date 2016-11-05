using System;
using System.Collections.Generic;

using RefactorMe.Exception;

namespace RefactorMe
{
	public class CurrencyServiceInMemory : ICurrencyService
	{
		private static Dictionary<CurrencyType, Currency> Currencies = new Dictionary<CurrencyType, Currency>();

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
