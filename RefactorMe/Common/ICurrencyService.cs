using System;
using System.Collections.Generic;

namespace RefactorMe.service
{
	public interface ICurrencyService
	{
		/// <summary>
		/// Add or update currency by currency type. If the type is not exist, add a new one.
		/// Otherwise update the exist one.
		/// </summary>
		void AddCurrency(Currency currency);

		/// <summary>
		/// Query all currency rate
		/// </summary>
		/// <returns>The currency rate list.</returns>
		List<Currency> GetCurrencyList();

		/// <summary>
		/// Query specific currency by currency type
		/// </summary>
		/// <returns>The currency rate.</returns>
		/// <param name="type">Type.</param>
		Currency GetCurrency(CurrencyType type);

		/// <summary>
		/// Removes the currency.
		/// </summary>
		/// <param name="type">Type.</param>
		void RemoveCurrency(CurrencyType type);
	}
}
