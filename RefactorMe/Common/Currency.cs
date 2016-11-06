using System;
namespace RefactorMe
{
	public class Currency
	{
		public CurrencyType Type { get; set; }

		public float Rate { get; set; }

		public Currency() { }

		public Currency(CurrencyType type, float rate)
		{
			this.Type = type;
			this.Rate = rate;
		}
	}

	public enum CurrencyType
	{
		NZ_DOLLOR,
		US_DOLLOR,
		EURO_DOLLOR,
	}
}
