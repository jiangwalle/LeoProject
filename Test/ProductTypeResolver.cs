using System;
using AutoMapper;
using RefactorMe.DontRefactor.Models;

namespace Test
{
	public class ProductTypeResolver : IValueResolver<object, Product, string>
	{
		public string Resolve(object source, Product destination, string member, ResolutionContext context)
		{
			string result = "unknown";
			switch (source.GetType().Name)
			{
				case "Lawnmower":
					result = "Lawnmower";
					break;
				case "PhoneCase":
					result = "Phone Case";
					break;
				case "TShirt":
					result = "T-Shirt";
					break;
			}

			return result;
		}
	}
}
