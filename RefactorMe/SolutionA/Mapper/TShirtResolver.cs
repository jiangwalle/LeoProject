using System;
using AutoMapper;

using RefactorMe.DontRefactor.Models;

namespace RefactorMe
{
	public class TShirtResolver : IValueResolver<TShirt, Product, string>
	{
		public string Resolve(TShirt source, Product destination, string member, ResolutionContext context)
		{
			return "T-Shirt";
		}
	}
}
