using System;
using AutoMapper;

using RefactorMe.DontRefactor.Models;

namespace Test
{
	public class CustomResolver : IValueResolver<Source, Destination, int>
	{
		public int Resolve(Source source, Destination destination, int member, ResolutionContext context)
		{
			return source.Value1 + source.Value2;
		}
	}

	public class TShirtResolve : IValueResolver<TShirt, Product, string>
	{
		public string Resolve(TShirt source, Product destination, string member, ResolutionContext context)
		{
			return "T-Shirt";
		}
	}
}
