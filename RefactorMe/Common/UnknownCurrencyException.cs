using System;
namespace RefactorMe.Exception
{
	public class UnknownCurrencyException : ApplicationException
	{
		public UnknownCurrencyException(string message) : base(message) { }

		public override string Message
		{
			get
			{
				return base.Message;
			}
		}
	}
}
